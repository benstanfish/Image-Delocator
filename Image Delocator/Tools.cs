using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace Image_Delocator
{
    public static class Tools
    {

        private static Dictionary<Int32, string> propDict()
        {
            Dictionary<Int32, string> temp = new Dictionary<Int32, string>();
            temp.Add(0, "PropertyTagGpsVer");
            temp.Add(1, "PropertyTagGpsLatitudeRef");
            temp.Add(2, "PropertyTagGpsLatitude");
            temp.Add(3, "PropertyTagGpsLongitudeRef");
            temp.Add(4, "PropertyTagGpsLongitude");
            temp.Add(5, "PropertyTagGpsAltitudeRef");
            temp.Add(6, "PropertyTagGpsAltitude");
            temp.Add(7, "PropertyTagGpsGpsTime");
            temp.Add(8, "PropertyTagGpsGpsSatellites");
            temp.Add(9, "PropertyTagGpsGpsStatus");
            temp.Add(10, "PropertyTagGpsGpsMeasureMode");
            temp.Add(11, "PropertyTagGpsGpsDop");
            temp.Add(12, "PropertyTagGpsSpeedRef");
            temp.Add(13, "PropertyTagGpsSpeed");
            temp.Add(14, "PropertyTagGpsTrackRef");
            temp.Add(15, "PropertyTagGpsTrack");
            temp.Add(16, "PropertyTagGpsImgDirRef");
            temp.Add(17, "PropertyTagGpsImgDir");
            temp.Add(18, "PropertyTagGpsMapDatum");
            temp.Add(19, "PropertyTagGpsDestLatRef");
            temp.Add(20, "PropertyTagGpsDestLat");
            temp.Add(21, "PropertyTagGpsDestLongRef");
            temp.Add(22, "PropertyTagGpsDestLong");
            temp.Add(23, "PropertyTagGpsDestBearRef");
            temp.Add(24, "PropertyTagGpsDestBear");
            temp.Add(25, "PropertyTagGpsDestDistRef");
            temp.Add(26, "PropertyTagGpsDestDist");
            temp.Add(254, "PropertyTagNewSubfileType");
            temp.Add(255, "PropertyTagSubfileType");
            temp.Add(256, "PropertyTagImageWidth");
            temp.Add(257, "PropertyTagImageHeight");
            temp.Add(258, "PropertyTagBitsPerSample");
            temp.Add(259, "PropertyTagCompression");
            temp.Add(262, "PropertyTagPhotometricInterp");
            temp.Add(263, "PropertyTagThreshHolding");
            temp.Add(264, "PropertyTagCellWidth");
            temp.Add(265, "PropertyTagCellHeight");
            temp.Add(266, "PropertyTagFillOrder");
            temp.Add(269, "PropertyTagDocumentName");
            temp.Add(270, "PropertyTagImageDescription");
            temp.Add(271, "PropertyTagEquipMake");
            temp.Add(272, "PropertyTagEquipModel");
            temp.Add(273, "PropertyTagStripOffsets");
            temp.Add(274, "PropertyTagOrientation");
            temp.Add(277, "PropertyTagSamplesPerPixel");
            temp.Add(278, "PropertyTagRowsPerStrip");
            temp.Add(279, "PropertyTagStripBytesCount");
            temp.Add(280, "PropertyTagMinSampleValue");
            temp.Add(281, "PropertyTagMaxSampleValue");
            temp.Add(282, "PropertyTagXResolution");
            temp.Add(283, "PropertyTagYResolution");
            temp.Add(284, "PropertyTagPlanarConfig");
            temp.Add(285, "PropertyTagPageName");
            temp.Add(286, "PropertyTagXPosition");
            temp.Add(287, "PropertyTagYPosition");
            temp.Add(288, "PropertyTagFreeOffset");
            temp.Add(289, "PropertyTagFreeByteCounts");
            temp.Add(290, "PropertyTagGrayResponseUnit");
            temp.Add(291, "PropertyTagGrayResponseCurve");
            temp.Add(292, "PropertyTagT4Option");
            temp.Add(293, "PropertyTagT6Option");
            temp.Add(296, "PropertyTagResolutionUnit");
            temp.Add(297, "PropertyTagPageNumber");
            temp.Add(301, "PropertyTagTransferFunction");
            temp.Add(305, "PropertyTagSoftwareUsed");
            temp.Add(306, "PropertyTagDateTime");
            temp.Add(315, "PropertyTagArtist");
            temp.Add(316, "PropertyTagHostComputer");
            temp.Add(317, "PropertyTagPredictor");
            temp.Add(318, "PropertyTagWhitePoint");
            temp.Add(319, "PropertyTagPrimaryChromaticities");
            temp.Add(320, "PropertyTagColorMap");
            temp.Add(321, "PropertyTagHalftoneHints");
            temp.Add(322, "PropertyTagTileWidth");
            temp.Add(323, "PropertyTagTileLength");
            temp.Add(324, "PropertyTagTileOffset");
            temp.Add(325, "PropertyTagTileByteCounts");
            temp.Add(332, "PropertyTagInkSet");
            temp.Add(333, "PropertyTagInkNames");
            temp.Add(334, "PropertyTagNumberOfInks");
            temp.Add(336, "PropertyTagDotRange");
            temp.Add(337, "PropertyTagTargetPrinter");
            temp.Add(338, "PropertyTagExtraSamples");
            temp.Add(339, "PropertyTagSampleFormat");
            temp.Add(340, "PropertyTagSMinSampleValue");
            temp.Add(341, "PropertyTagSMaxSampleValue");
            temp.Add(342, "PropertyTagTransferRange");
            temp.Add(512, "PropertyTagJPEGProc");
            temp.Add(513, "PropertyTagJPEGInterFormat");
            temp.Add(514, "PropertyTagJPEGInterLength");
            temp.Add(515, "PropertyTagJPEGRestartInterval");
            temp.Add(517, "PropertyTagJPEGLosslessPredictors");
            temp.Add(518, "PropertyTagJPEGPointTransforms");
            temp.Add(519, "PropertyTagJPEGQTables");
            temp.Add(520, "PropertyTagJPEGDCTables");
            temp.Add(521, "PropertyTagJPEGACTables");
            temp.Add(529, "PropertyTagYCbCrCoefficients");
            temp.Add(530, "PropertyTagYCbCrSubsampling");
            temp.Add(531, "PropertyTagYCbCrPositioning");
            temp.Add(532, "PropertyTagREFBlackWhite");
            temp.Add(769, "PropertyTagGamma");
            temp.Add(770, "PropertyTagICCProfileDescriptor");
            temp.Add(771, "PropertyTagSRGBRenderingIntent");
            temp.Add(800, "PropertyTagImageTitle");
            temp.Add(20481, "PropertyTagResolutionXUnit");
            temp.Add(20482, "PropertyTagResolutionYUnit");
            temp.Add(20483, "PropertyTagResolutionXLengthUnit");
            temp.Add(20484, "PropertyTagResolutionYLengthUnit");
            temp.Add(20485, "PropertyTagPrintFlags");
            temp.Add(20486, "PropertyTagPrintFlagsVersion");
            temp.Add(20487, "PropertyTagPrintFlagsCrop");
            temp.Add(20488, "PropertyTagPrintFlagsBleedWidth");
            temp.Add(20489, "PropertyTagPrintFlagsBleedWidthScale");
            temp.Add(20490, "PropertyTagHalftoneLPI");
            temp.Add(20491, "PropertyTagHalftoneLPIUnit");
            temp.Add(20492, "PropertyTagHalftoneDegree");
            temp.Add(20493, "PropertyTagHalftoneShape");
            temp.Add(20494, "PropertyTagHalftoneMisc");
            temp.Add(20495, "PropertyTagHalftoneScreen");
            temp.Add(20496, "PropertyTagJPEGQuality");
            temp.Add(20497, "PropertyTagGridSize");
            temp.Add(20498, "PropertyTagThumbnailFormat");
            temp.Add(20499, "PropertyTagThumbnailWidth");
            temp.Add(20500, "PropertyTagThumbnailHeight");
            temp.Add(20501, "PropertyTagThumbnailColorDepth");
            temp.Add(20502, "PropertyTagThumbnailPlanes");
            temp.Add(20503, "PropertyTagThumbnailRawBytes");
            temp.Add(20504, "PropertyTagThumbnailSize");
            temp.Add(20505, "PropertyTagThumbnailCompressedSize");
            temp.Add(20506, "PropertyTagColorTransferFunction");
            temp.Add(20507, "PropertyTagThumbnailData");
            temp.Add(20512, "PropertyTagThumbnailImageWidth");
            temp.Add(20513, "PropertyTagThumbnailImageHeight");
            temp.Add(20514, "PropertyTagThumbnailBitsPerSample");
            temp.Add(20515, "PropertyTagThumbnailCompression");
            temp.Add(20516, "PropertyTagThumbnailPhotometricInterp");
            temp.Add(20517, "PropertyTagThumbnailImageDescription");
            temp.Add(20518, "PropertyTagThumbnailEquipMake");
            temp.Add(20519, "PropertyTagThumbnailEquipModel");
            temp.Add(20520, "PropertyTagThumbnailStripOffsets");
            temp.Add(20521, "PropertyTagThumbnailOrientation");
            temp.Add(20522, "PropertyTagThumbnailSamplesPerPixel");
            temp.Add(20523, "PropertyTagThumbnailRowsPerStrip");
            temp.Add(20524, "PropertyTagThumbnailStripBytesCount");
            temp.Add(20525, "PropertyTagThumbnailResolutionX");
            temp.Add(20526, "PropertyTagThumbnailResolutionY");
            temp.Add(20527, "PropertyTagThumbnailPlanarConfig");
            temp.Add(20528, "PropertyTagThumbnailResolutionUnit");
            temp.Add(20529, "PropertyTagThumbnailTransferFunction");
            temp.Add(20530, "PropertyTagThumbnailSoftwareUsed");
            temp.Add(20531, "PropertyTagThumbnailDateTime");
            temp.Add(20532, "PropertyTagThumbnailArtist");
            temp.Add(20533, "PropertyTagThumbnailWhitePoint");
            temp.Add(20534, "PropertyTagThumbnailPrimaryChromaticities");
            temp.Add(20535, "PropertyTagThumbnailYCbCrCoefficients");
            temp.Add(20536, "PropertyTagThumbnailYCbCrSubsampling");
            temp.Add(20537, "PropertyTagThumbnailYCbCrPositioning");
            temp.Add(20538, "PropertyTagThumbnailRefBlackWhite");
            temp.Add(20539, "PropertyTagThumbnailCopyRight");
            temp.Add(20624, "PropertyTagLuminanceTable");
            temp.Add(20625, "PropertyTagChrominanceTable");
            temp.Add(20736, "PropertyTagFrameDelay");
            temp.Add(20737, "PropertyTagLoopCount");
            temp.Add(20738, "PropertyTagGlobalPalette");
            temp.Add(20739, "PropertyTagIndexBackground");
            temp.Add(20740, "PropertyTagIndexTransparent");
            temp.Add(20752, "PropertyTagPixelUnit");
            temp.Add(20753, "PropertyTagPixelPerUnitX");
            temp.Add(20754, "PropertyTagPixelPerUnitY");
            temp.Add(20755, "PropertyTagPaletteHistogram");
            temp.Add(33432, "PropertyTagCopyright");
            temp.Add(33434, "PropertyTagExifExposureTime");
            temp.Add(33437, "PropertyTagExifFNumber");
            temp.Add(34665, "PropertyTagExifIFD");
            temp.Add(34675, "PropertyTagICCProfile");
            temp.Add(34850, "PropertyTagExifExposureProg");
            temp.Add(34852, "PropertyTagExifSpectralSense");
            temp.Add(34853, "PropertyTagGpsIFD");
            temp.Add(34855, "PropertyTagExifISOSpeed");
            temp.Add(34856, "PropertyTagExifOECF");
            temp.Add(36864, "PropertyTagExifVer");
            temp.Add(36867, "PropertyTagExifDTOrig");
            temp.Add(36868, "PropertyTagExifDTDigitized");
            temp.Add(37121, "PropertyTagExifCompConfig");
            temp.Add(37122, "PropertyTagExifCompBPP");
            temp.Add(37377, "PropertyTagExifShutterSpeed");
            temp.Add(37378, "PropertyTagExifAperture");
            temp.Add(37379, "PropertyTagExifBrightness");
            temp.Add(37380, "PropertyTagExifExposureBias");
            temp.Add(37381, "PropertyTagExifMaxAperture");
            temp.Add(37382, "PropertyTagExifSubjectDist");
            temp.Add(37383, "PropertyTagExifMeteringMode");
            temp.Add(37384, "PropertyTagExifLightSource");
            temp.Add(37385, "PropertyTagExifFlash");
            temp.Add(37386, "PropertyTagExifFocalLength");
            temp.Add(37500, "PropertyTagExifMakerNote");
            temp.Add(37510, "PropertyTagExifUserComment");
            temp.Add(37520, "PropertyTagExifDTSubsec");
            temp.Add(37521, "PropertyTagExifDTOrigSS");
            temp.Add(37522, "PropertyTagExifDTDigSS");
            temp.Add(40960, "PropertyTagExifFPXVer");
            temp.Add(40961, "PropertyTagExifColorSpace");
            temp.Add(40962, "PropertyTagExifPixXDim");
            temp.Add(40963, "PropertyTagExifPixYDim");
            temp.Add(40964, "PropertyTagExifRelatedWav");
            temp.Add(40965, "PropertyTagExifInterop");
            temp.Add(41483, "PropertyTagExifFlashEnergy");
            temp.Add(41484, "PropertyTagExifSpatialFR");
            temp.Add(41486, "PropertyTagExifFocalXRes");
            temp.Add(41487, "PropertyTagExifFocalYRes");
            temp.Add(41488, "PropertyTagExifFocalResUnit");
            temp.Add(41492, "PropertyTagExifSubjectLoc");
            temp.Add(41493, "PropertyTagExifExposureIndex");
            temp.Add(41495, "PropertyTagExifSensingMethod");
            temp.Add(41728, "PropertyTagExifFileSource");
            temp.Add(41729, "PropertyTagExifSceneType");
            temp.Add(41730, "PropertyTagExifCfaPattern");
            return temp;
        }


        public static string GetFilePath()
        {
            string myPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = ProjectFolders.ImagesFolder();
                //ofd.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
                ofd.FilterIndex = 0;
                ofd.RestoreDirectory = false;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    myPath = ofd.FileName;
                }
            }
            return myPath;
        }

        public static List<string> ReadPropertyItems(string filePath)
        {
            List<string> temp = new List<string>();

            var charCount = filePath.Length + 6;
            string line = new String('-', charCount);
            temp.Add(line);
            temp.Add("File: " + filePath);
            temp.Add("Date: " + DateTime.Now.ToString("yyyy MMMM dd hh:mm:ss"));
            temp.Add(line + "\n");
            Dictionary<int, string> props = propDict();
            try
            {
                if (File.Exists(filePath))
                {
                    Image image = new Bitmap(filePath);
                    PropertyItem[] propItems = image.PropertyItems;
                    
                  
                    int i = 0;
                    foreach (PropertyItem propItem in propItems)
                    {
                        if (props.ContainsKey(propItem.Id))
                        {
                            var propDesc = props[propItem.Id];
                            var propVal = GetValueFromType(propItem);
                            string itemData = "ID: " + propItem.Id.ToString("d") + " ("+ propItem.Id.ToString("x") +"), Desc: " + propDesc + ", Type: " + propItem.Type + ", Value: " + propVal;
                            temp.Add(itemData);
                        }
                        else
                        {
                            var propVal = GetValueFromType(propItem);
                            string itemData = "ID: " + propItem.Id.ToString("d") + " (" + propItem.Id.ToString("x") + ") [No Desc.], Value: " + propVal;
                            temp.Add(itemData);
                        }
                    }
                }
                return temp;
            }
            catch (Exception)
            {
                return temp;
            }
        }

        public static void Logger(List<string> dataToLog, string filePath = null)
        {
            string tempPath;
            if (filePath == null)
            {
                tempPath = ProjectFolders.ConfigFolder() + @"log_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";
            }
            else
            {
                tempPath = filePath;
            }
            using (var file = new StreamWriter(tempPath))
            {
                foreach (string line in dataToLog)
                {
                    file.WriteLine(line);
                }
            }
        }

        public static void WriteImageData(string filePath)
        {
            Logger(ReadPropertyItems(filePath));
        }

        public static string GetValueFromType(PropertyItem propertyItem)
        {
            var propType = propertyItem.Type;
          
            switch (propType)
            {
                case 1:
                    //return Encoding.UTF8.GetString(propertyItem.Value, 0, propertyItem.Value.Length);
                    return BitConverter.ToString(propertyItem.Value);
                case 2:
                    return Encoding.ASCII.GetString(propertyItem.Value,0,propertyItem.Value.Length);
                    break;
                case 3: case 4:
                    return BitConverter.ToString(propertyItem.Value);
                    break;
                case 5:
                    //return BitConverter.ToDouble(propertyItem.Value, 0).ToString();
                    return BitConverter.ToString(propertyItem.Value);
                    break;
                case 6: case 7: case 8:
                    break;
                case 9: case 10:
                    return propertyItem.Value.ToString();
                    break;
                default:
                    return propertyItem.Value.ToString();
                    break;
            }

            return null;
        }


    }



}
