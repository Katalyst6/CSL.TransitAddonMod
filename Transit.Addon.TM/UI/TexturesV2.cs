using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Transit.Addon.TM.Traffic;
using Transit.Addon.TM.UI;
using Transit.Addon.TM.Data;
using Transit.Framework.Network;
using UnityEngine;

namespace Transit.Addon.TM.UI
{
    public class TexturesV2
    {
        public static readonly Texture2D RedLightTexture2D;
        public static readonly Texture2D YellowRedLightTexture2D;
        public static readonly Texture2D YellowLightTexture2D;
        public static readonly Texture2D GreenLightTexture2D;
        public static readonly Texture2D RedLightStraightTexture2D;
        public static readonly Texture2D YellowLightStraightTexture2D;
        public static readonly Texture2D GreenLightStraightTexture2D;
        public static readonly Texture2D RedLightRightTexture2D;
        public static readonly Texture2D YellowLightRightTexture2D;
        public static readonly Texture2D GreenLightRightTexture2D;
        public static readonly Texture2D RedLightLeftTexture2D;
        public static readonly Texture2D YellowLightLeftTexture2D;
        public static readonly Texture2D GreenLightLeftTexture2D;
        public static readonly Texture2D RedLightForwardRightTexture2D;
        public static readonly Texture2D YellowLightForwardRightTexture2D;
        public static readonly Texture2D GreenLightForwardRightTexture2D;
        public static readonly Texture2D RedLightForwardLeftTexture2D;
        public static readonly Texture2D YellowLightForwardLeftTexture2D;
        public static readonly Texture2D GreenLightForwardLeftTexture2D;
        public static readonly Texture2D PedestrianRedLightTexture2D;
        public static readonly Texture2D PedestrianGreenLightTexture2D;
        public static readonly Texture2D LightModeTexture2D;
        public static readonly Texture2D LightCounterTexture2D;
        public static readonly Texture2D PedestrianModeAutomaticTexture2D;
        public static readonly Texture2D PedestrianModeManualTexture2D;
        public static readonly Texture2D SignStopTexture2D;
        public static readonly Texture2D SignYieldTexture2D;
        public static readonly Texture2D SignPriorityTexture2D;
        public static readonly Texture2D SignNoneTexture2D;
		public static readonly Texture2D SignRemoveTexture2D;
		public static readonly Texture2D ClockPlayTexture2D;
		public static readonly Texture2D ClockPauseTexture2D;
		public static readonly Texture2D ClockTestTexture2D;
		public static readonly Dictionary<ushort, Texture2D> SpeedLimitTextures;
		public static readonly Dictionary<ExtendedUnitType, Dictionary<bool, Texture2D>> VehicleRestrictionTextures;
		public static readonly Dictionary<ExtendedUnitType, Texture2D> VehicleInfoSignTextures;
		public static readonly Texture2D LaneChangeForbiddenTexture2D;
		public static readonly Texture2D LaneChangeAllowedTexture2D;

		static TexturesV2()
        {
            // simple
            RedLightTexture2D = LoadDllResource("light_1_1.png", 103, 243);
            YellowRedLightTexture2D = LoadDllResource("light_1_2.png", 103, 243);
            GreenLightTexture2D = LoadDllResource("light_1_3.png", 103, 243);
            // forward
            RedLightStraightTexture2D = LoadDllResource("light_2_1.png", 103, 243);
            YellowLightStraightTexture2D = LoadDllResource("light_2_2.png", 103, 243);
            GreenLightStraightTexture2D = LoadDllResource("light_2_3.png", 103, 243);
            // right
            RedLightRightTexture2D = LoadDllResource("light_3_1.png", 103, 243);
            YellowLightRightTexture2D = LoadDllResource("light_3_2.png", 103, 243);
            GreenLightRightTexture2D = LoadDllResource("light_3_3.png", 103, 243);
            // left
            RedLightLeftTexture2D = LoadDllResource("light_4_1.png", 103, 243);
            YellowLightLeftTexture2D = LoadDllResource("light_4_2.png", 103, 243);
            GreenLightLeftTexture2D = LoadDllResource("light_4_3.png", 103, 243);
            // forwardright
            RedLightForwardRightTexture2D = LoadDllResource("light_5_1.png", 103, 243);
            YellowLightForwardRightTexture2D = LoadDllResource("light_5_2.png", 103, 243);
            GreenLightForwardRightTexture2D = LoadDllResource("light_5_3.png", 103, 243);
            // forwardleft
            RedLightForwardLeftTexture2D = LoadDllResource("light_6_1.png", 103, 243);
            YellowLightForwardLeftTexture2D = LoadDllResource("light_6_2.png", 103, 243);
            GreenLightForwardLeftTexture2D = LoadDllResource("light_6_3.png", 103, 243);
            // yellow
            YellowLightTexture2D = LoadDllResource("light_yellow.png", 103, 243);
            // pedestrian
            PedestrianRedLightTexture2D = LoadDllResource("pedestrian_light_1.png", 73, 123);
            PedestrianGreenLightTexture2D = LoadDllResource("pedestrian_light_2.png", 73, 123);
            // light mode
            LightModeTexture2D = LoadDllResource(Translation.GetTranslatedFileName("light_mode.png"), 103, 95);
            LightCounterTexture2D = LoadDllResource(Translation.GetTranslatedFileName("light_counter.png"), 103, 95);
            // pedestrian mode
            PedestrianModeAutomaticTexture2D = LoadDllResource("pedestrian_mode_1.png", 73, 70);
            PedestrianModeManualTexture2D = LoadDllResource("pedestrian_mode_2.png", 73, 73);

            // priority signs
            SignStopTexture2D = LoadDllResource("sign_stop.png", 200, 200);
            SignYieldTexture2D = LoadDllResource("sign_yield.png", 200, 200);
            SignPriorityTexture2D = LoadDllResource("sign_priority.png", 200, 200);
            SignNoneTexture2D = LoadDllResource("sign_none.png", 200, 200);

			// delete priority sign
			SignRemoveTexture2D = LoadDllResource("remove_signs.png", 256, 256);
			// timer
			ClockPlayTexture2D = LoadDllResource("clock_play.png", 512, 512);
			ClockPauseTexture2D = LoadDllResource("clock_pause.png", 512, 512);
			ClockTestTexture2D = LoadDllResource("clock_test.png", 512, 512);

			SpeedLimitTextures = new Dictionary<ushort, Texture2D>();
			foreach (ushort speedLimit in SpeedLimitManager.AvailableSpeedLimits) {
				SpeedLimitTextures.Add(speedLimit, LoadDllResource(speedLimit.ToString() + ".png", 200, 200));
			}

			VehicleRestrictionTextures = new Dictionary<ExtendedUnitType, Dictionary<bool, Texture2D>>();
			VehicleRestrictionTextures[ExtendedUnitType.Bus] = new Dictionary<bool, Texture2D>();
			VehicleRestrictionTextures[ExtendedUnitType.CargoTrain] = new Dictionary<bool, Texture2D>();
			VehicleRestrictionTextures[ExtendedUnitType.CargoTruck] = new Dictionary<bool, Texture2D>();
			VehicleRestrictionTextures[ExtendedUnitType.Emergency] = new Dictionary<bool, Texture2D>();
			VehicleRestrictionTextures[ExtendedUnitType.PassengerCar] = new Dictionary<bool, Texture2D>();
			VehicleRestrictionTextures[ExtendedUnitType.PassengerTrain] = new Dictionary<bool, Texture2D>();
			VehicleRestrictionTextures[ExtendedUnitType.ServiceVehicle] = new Dictionary<bool, Texture2D>();
			VehicleRestrictionTextures[ExtendedUnitType.Taxi] = new Dictionary<bool, Texture2D>();

			foreach (KeyValuePair<ExtendedUnitType, Dictionary<bool, Texture2D>> e in VehicleRestrictionTextures) {
				foreach (bool b in new bool[]{false, true}) {
					string suffix = b ? "allowed" : "forbidden";
					e.Value[b] = LoadDllResource(e.Key.ToString().ToLower() + "_" + suffix + ".png", 200, 200);
				}
			}

			LaneChangeAllowedTexture2D = LoadDllResource("lanechange_allowed.png", 200, 200);
			LaneChangeForbiddenTexture2D = LoadDllResource("lanechange_forbidden.png", 200, 200);

			VehicleInfoSignTextures = new Dictionary<ExtendedUnitType, Texture2D>();
			VehicleInfoSignTextures[ExtendedUnitType.Bicycle] = LoadDllResource("bicycle_infosign.png", 449, 411);
			VehicleInfoSignTextures[ExtendedUnitType.Bus] = LoadDllResource("bus_infosign.png", 449, 411);
			VehicleInfoSignTextures[ExtendedUnitType.CargoTrain] = LoadDllResource("cargotrain_infosign.png", 449, 411);
			VehicleInfoSignTextures[ExtendedUnitType.CargoTruck] = LoadDllResource("cargotruck_infosign.png", 449, 411);
			VehicleInfoSignTextures[ExtendedUnitType.Emergency] = LoadDllResource("emergency_infosign.png", 449, 411);
			VehicleInfoSignTextures[ExtendedUnitType.PassengerCar] = LoadDllResource("passengercar_infosign.png", 449, 411);
			VehicleInfoSignTextures[ExtendedUnitType.PassengerTrain] = LoadDllResource("passengertrain_infosign.png", 449, 411);
			VehicleInfoSignTextures[ExtendedUnitType.ServiceVehicle] = LoadDllResource("service_infosign.png", 449, 411);
			VehicleInfoSignTextures[ExtendedUnitType.Taxi] = LoadDllResource("taxi_infosign.png", 449, 411);
			VehicleInfoSignTextures[ExtendedUnitType.Tram] = LoadDllResource("tram_infosign.png", 449, 411);
		}

        private static Texture2D LoadDllResource(string resourceName, int width, int height)
        {
            var myAssembly = Assembly.GetExecutingAssembly();
            var myStream = myAssembly.GetManifestResourceStream("Transit.Addon.TM.Resources." + resourceName);

            var texture = new Texture2D(width, height, TextureFormat.ARGB32, false);

            texture.LoadImage(ReadToEnd(myStream));

            return texture;
        }

        static byte[] ReadToEnd(Stream stream)
        {
            var originalPosition = stream.Position;
            stream.Position = 0;

            try
            {
                var readBuffer = new byte[4096];

                var totalBytesRead = 0;
                int bytesRead;

                while ((bytesRead = stream.Read(readBuffer, totalBytesRead, readBuffer.Length - totalBytesRead)) > 0)
                {
                    totalBytesRead += bytesRead;

                    if (totalBytesRead != readBuffer.Length)
                        continue;

                    var nextByte = stream.ReadByte();
                    if (nextByte == -1)
                        continue;

                    var temp = new byte[readBuffer.Length * 2];
                    Buffer.BlockCopy(readBuffer, 0, temp, 0, readBuffer.Length);
                    Buffer.SetByte(temp, totalBytesRead, (byte)nextByte);
                    readBuffer = temp;
                    totalBytesRead++;
                }

                var buffer = readBuffer;
                if (readBuffer.Length == totalBytesRead)
                    return buffer;

                buffer = new byte[totalBytesRead];
                Buffer.BlockCopy(readBuffer, 0, buffer, 0, totalBytesRead);
                return buffer;
            }
            finally
            {
                stream.Position = originalPosition;
            }
        }
	}
}