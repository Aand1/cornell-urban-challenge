using System;
using System.Collections.Generic;
using System.Text;

namespace VelodyneInterface
{
	public struct RCFVCFHCF
	{
		public double RCFSIN; public double VCFSIN; public double HCF;
		public double RCFCOS; public double VCFCOS;
		public RCFVCFHCF(double RCFSIN, double VCFSIN, double RCFCOS, double VCFCOS, double HCF)
		{
			this.RCFCOS = RCFCOS; this.VCFCOS = VCFCOS; this.RCFSIN = RCFSIN; this.VCFSIN = VCFSIN; this.HCF = HCF;
		}
	}
	public static class VelodyneAngles
	{
		public static RCFVCFHCF[] topblockDegrees = new RCFVCFHCF[32];
		public static RCFVCFHCF[] bottomblockDegrees = new RCFVCFHCF[32];

		static VelodyneAngles()
		{
			topblockDegrees[0] = new RCFVCFHCF(-0.08636, -0.124608004, 0.996263996, 0.99220605, 4);
			topblockDegrees[1] = new RCFVCFHCF(-0.049106667, -0.118712821, 0.99879354, 0.992928631, -4);
			topblockDegrees[2] = new RCFVCFHCF(0.049106667, 0.005547006, 0.99879354, 0.999984615, 4);
			topblockDegrees[3] = new RCFVCFHCF(0.08636, 0.011486092, 0.996263996, 0.999934033, -4);
			topblockDegrees[4] = new RCFVCFHCF(-0.012104643, -0.112815635, 0.999926736, 0.993615938, 4);
			topblockDegrees[5] = new RCFVCFHCF(0.025148753, -0.106916449, 0.99968372, 0.994268009, -4);
			topblockDegrees[6] = new RCFVCFHCF(-0.025651246, -0.148168656, 0.999670953, 0.988962107, 4);
			topblockDegrees[7] = new RCFVCFHCF(0.011602023, -0.142281511, 0.999932694, 0.989826233, -4);
			topblockDegrees[8] = new RCFVCFHCF(0.062151658, -0.101015263, 0.998066717, 0.994884876, 4);
			topblockDegrees[9] = new RCFVCFHCF(0.099406514, -0.09511208, 0.995046906, 0.99546657, -4);
			topblockDegrees[10] = new RCFVCFHCF(0.048604612, -0.136392351, 0.998818097, 0.990654898, 4);
			topblockDegrees[11] = new RCFVCFHCF(0.085859212, -0.130501182, 0.99630728, 0.991448154, -4);
			topblockDegrees[12] = new RCFVCFHCF(-0.087111141, -0.053733971, 0.996198599, 0.998555287, 4);
			topblockDegrees[13] = new RCFVCFHCF(-0.049859725, -0.047814845, 0.99875623, 0.998856216, -4);
			topblockDegrees[14] = new RCFVCFHCF(-0.100656848, -0.089206901, 0.994921202, 0.996013117, 4);
			topblockDegrees[15] = new RCFVCFHCF(-0.063405816, -0.083299727, 0.997987827, 0.996524538, -4);
			topblockDegrees[16] = new RCFVCFHCF(-0.012858566, -0.041893728, 0.999917325, 0.999122072, 4);
			topblockDegrees[17] = new RCFVCFHCF(0.024395002, -0.035970618, 0.999702398, 0.999352848, -4);
			topblockDegrees[18] = new RCFVCFHCF(-0.026404972, -0.07739056, 0.999651328, 0.997000853, 4);
			topblockDegrees[19] = new RCFVCFHCF(0.010848088, -0.071479401, 0.999941158, 0.997442076, -4);
			topblockDegrees[20] = new RCFVCFHCF(0.061399116, -0.030045516, 0.998113294, 0.999548532, 4);
			topblockDegrees[21] = new RCFVCFHCF(0.098656238, -0.02411842, 0.995121574, 0.999709109, -4);
			topblockDegrees[22] = new RCFVCFHCF(0.047851507, -0.065566249, 0.99885446, 0.997848218, 4);
			topblockDegrees[23] = new RCFVCFHCF(0.08510799, -0.059651106, 0.996371733, 0.998219287, -4);
			topblockDegrees[24] = new RCFVCFHCF(-0.087862232, 0.017427184, 0.996132636, 0.999848135, 4);
			topblockDegrees[25] = new RCFVCFHCF(-0.050612755, 0.023370284, 0.998718353, 0.999726878, -4);
			topblockDegrees[26] = new RCFVCFHCF(-0.101406972, -0.018189329, 0.994845026, 0.99983456, 4);
			topblockDegrees[27] = new RCFVCFHCF(-0.064158263, -0.012258243, 0.997939736, 0.999924865, -4);
			topblockDegrees[28] = new RCFVCFHCF(-0.013612482, 0.029315394, 0.999907346, 0.999570211, 4);
			topblockDegrees[29] = new RCFVCFHCF(0.023641237, 0.035262518, 0.999720507, 0.999378084, -4);
			topblockDegrees[30] = new RCFVCFHCF(-0.027158684, -0.00632516, 0.999631135, 0.999979996, 4);
			topblockDegrees[31] = new RCFVCFHCF(0.010094148, -0.000390077, 0.999949053, 0.999999924, -4);

			bottomblockDegrees[0] = new RCFVCFHCF(-0.12954, -0.386515978, 0.991574197, 0.922282711, 4);
			bottomblockDegrees[1] = new RCFVCFHCF(-0.07366, -0.378262058, 0.997283412, 0.925698556, -4);
			bottomblockDegrees[2] = new RCFVCFHCF(0.07366, -0.199606138, 0.997283412, 0.979876211, 4);
			bottomblockDegrees[3] = new RCFVCFHCF(0.12954, -0.190845208, 0.991574197, 0.981620144, -4);
			bottomblockDegrees[4] = new RCFVCFHCF(-0.018031287, -0.369984899, 0.999837423, 0.929037768, 4);
			bottomblockDegrees[5] = new RCFVCFHCF(0.037848854, -0.361684557, 0.999283475, 0.932300531, -4);
			bottomblockDegrees[6] = new RCFVCFHCF(-0.038351144, -0.419297955, 0.999264324, 0.907848679, 4);
			bottomblockDegrees[7] = new RCFVCFHCF(0.017528712, -0.411137663, 0.99984636, 0.911573268, -4);
			bottomblockDegrees[8] = new RCFVCFHCF(0.093479558, -0.353361082, 0.995621199, 0.93548701, 4);
			bottomblockDegrees[9] = new RCFVCFHCF(0.149363003, -0.345014517, 0.98878243, 0.938597349, -4);
			bottomblockDegrees[10] = new RCFVCFHCF(0.073158701, -0.40295385, 0.997320312, 0.915220298, 4);
			bottomblockDegrees[11] = new RCFVCFHCF(0.129041564, -0.394746598, 0.991639186, 0.918790032, -4);
			bottomblockDegrees[12] = new RCFVCFHCF(-0.130287592, -0.285944588, 0.991476244, 0.958246154, 4);
			bottomblockDegrees[13] = new RCFVCFHCF(-0.074411913, -0.277414227, 0.99722759, 0.960750408, -4);
			bottomblockDegrees[14] = new RCFVCFHCF(-0.150605425, -0.336644901, 0.988593954, 0.941631675, 4);
			bottomblockDegrees[15] = new RCFVCFHCF(-0.094730618, -0.328252267, 0.995502943, 0.944590096, -4);
			bottomblockDegrees[16] = new RCFVCFHCF(-0.018785142, -0.268860924, 0.999823544, 0.963179009, 4);
			bottomblockDegrees[17] = new RCFVCFHCF(0.037095401, -0.260284668, 0.999311729, 0.965531921, -4);
			bottomblockDegrees[18] = new RCFVCFHCF(-0.03910456, -0.319836642, 0.999235124, 0.947472703, 4);
			bottomblockDegrees[19] = new RCFVCFHCF(0.01677484, -0.311398048, 0.999859292, 0.950279567, -4);
			bottomblockDegrees[20] = new RCFVCFHCF(0.092728851, -0.251685444, 0.995691398, 0.967809091, 4);
			bottomblockDegrees[21] = new RCFVCFHCF(0.148617436, -0.243063222, 0.988894766, 0.970010448, -4);
			bottomblockDegrees[22] = new RCFVCFHCF(0.072406719, -0.302936501, 0.997375189, 0.953010743, 4);
			bottomblockDegrees[23] = new RCFVCFHCF(0.128293849, -0.294452013, 0.991736199, 0.955666266, -4);
			bottomblockDegrees[24] = new RCFVCFHCF(-0.131035111, -0.182060979, 0.991377728, 0.983287242, 4);
			bottomblockDegrees[25] = new RCFVCFHCF(-0.075163784, -0.173253382, 0.997171202, 0.984877285, -4);
			bottomblockDegrees[26] = new RCFVCFHCF(-0.151350764, -0.234417995, 0.988480119, 0.972135898, 4);
			bottomblockDegrees[27] = new RCFVCFHCF(-0.095481183, -0.22574971, 0.995431235, 0.974185336, -4);
			bottomblockDegrees[28] = new RCFVCFHCF(-0.019538985, -0.164422345, 0.999809096, 0.986390031, 4);
			bottomblockDegrees[29] = new RCFVCFHCF(0.036341927, -0.155567788, 0.999339414, 0.987825219, -4);
			bottomblockDegrees[30] = new RCFVCFHCF(-0.039857955, -0.217058336, 0.999205356, 0.976158634, 4);
			bottomblockDegrees[31] = new RCFVCFHCF(0.01602096, -0.208343829, 0.999871656, 0.978055647, -4);



		}
	}
}
