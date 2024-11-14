#HeatControlprogram_protoType

加熱制御システムの試作型
電圧、電流、抵抗、電力を電源シミュレータ（TAKASAGO )の一次、二次両側のモニター
DMM３台を使用し、二次側の電圧、電流（クランプメータによる起電力変換）、温度（熱電対による決定）の３パラメータの測定
全ての機器はGPIB-USBを用いた接続を行う

GPIB　adress
1: DMM1 2次電圧用
2: DMM2 ２次電流用
3: DMM3　熱電対用
4: 電源シミュレータ（TAKASAGO:）

使用参照
Using NationalInstruments.Visa;
Using Ivi.Visa;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
using System.Xml.Schema;
using MathNet.Numerics;  //chart用
using System.Text.RegularExpressions;
using System.Globalization;
