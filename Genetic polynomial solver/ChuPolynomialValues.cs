﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_polynomial_solver {
    internal static class ChuPolynomialValues {
        public static double[] XValues = {
            -25,
            -24.501616379310345,
            -24.00323275862069,
            -23.504849137931036,
            -23.00646551724138,
            -22.508081896551726,
            -22.00969827586207,
            -21.511314655172413,
            -21.012931034482758,
            -20.514547413793103,
            -20.016163793103445,
            -19.51778017241379,
            -19.019396551724135,
            -18.52101293103448,
            -18.022629310344826,
            -17.52424568965517,
            -17.025862068965516,
            -16.52747844827586,
            -16.029094827586206,
            -15.530711206896552,
            -15.032327586206895,
            -14.533943965517238,
            -14.035560344827584,
            -13.537176724137929,
            -13.038793103448274,
            -12.789601293103447,
            -12.54040948275862,
            -12.291217672413792,
            -12.042025862068964,
            -11.792834051724137,
            -11.54364224137931,
            -11.294450431034482,
            -11.045258620689655,
            -10.796066810344827,
            -10.546875,
            -10.297683189655173,
            -10.048491379310345,
            -9.799299568965518,
            -9.55010775862069,
            -9.300915948275861,
            -9.051724137931034,
            -8.802532327586206,
            -8.553340517241377,
            -8.30414870689655,
            -8.054956896551722,
            -7.805765086206895,
            -7.556573275862068,
            -7.30738146551724,
            -7.058189655172413,
            -6.808997844827585,
            -6.559806034482758,
            -6.310614224137931,
            -6.061422413793102,
            -5.812230603448274,
            -5.563038793103447,
            -5.313846982758619,
            -5.064655172413792,
            -4.815463362068964,
            -4.566271551724137,
            -4.31707974137931,
            -4.067887931034481,
            -3.818696120689654,
            -3.5695043103448265,
            -3.320312499999999,
            -3.0711206896551713,
            -2.8219288793103434,
            -2.572737068965516,
            -2.3235452586206886,
            -2.074353448275861,
            -1.8251616379310336,
            -1.575969827586206,
            -1.3267780172413783,
            -1.0775862068965507,
            -0.8283943965517231,
            -0.5792025862068955,
            -0.3300107758620679,
            0.16837284482758727,
            0.41756465517241487,
            0.6667564655172424,
            0.9159482758620701,
            1.1651400862068977,
            1.414331896551725,
            1.6635237068965527,
            1.9127155172413803,
            2.161907327586208,
            2.4110991379310356,
            2.660290948275863,
            2.909482758620691,
            3.1586745689655187,
            3.407866379310346,
            3.6570581896551735,
            3.906250000000001,
            4.155441810344829,
            4.404633620689657,
            4.653825431034484,
            4.903017241379311,
            5.152209051724139,
            5.401400862068966,
            5.650592672413794,
            5.899784482758622,
            6.14897629310345,
            6.398168103448278,
            6.647359913793105,
            6.896551724137932,
            7.14574353448276,
            7.394935344827587,
            7.644127155172415,
            7.893318965517243,
            8.142510775862071,
            8.391702586206899,
            8.640894396551726,
            8.890086206896553,
            9.38846982758621,
            9.886853448275865,
            10.38523706896552,
            10.883620689655174,
            11.880387931034484,
            12.877155172413794,
            13.873922413793103,
            14.870689655172415,
            15.867456896551726,
            16.864224137931036,
            17.860991379310345,
            18.857758620689655,
            19.35614224137931,
            19.854525862068968,
            20.352909482758623,
            20.851293103448278,
            21.349676724137932,
            21.848060344827587,
            22.346443965517242,
            22.844827586206897,
            23.34321120689655,
            23.841594827586206,
            24.33997844827586,
            24.838362068965516,
            25.33674568965517,
            25.835129310344826,
            26.333512931034484,
            26.83189655172414,
            27.330280172413794,
            27.828663793103452,
            28.327047413793107,
            28.82543103448276,
            29.323814655172416,
            29.82219827586207,
            30.320581896551726,
            30.81896551724138,
            31.317349137931036,
            31.81573275862069,
            32.31411637931035,
            32.8125,
            33.31088362068965,
            33.80926724137931,
            34.30765086206897,
            34.80603448275862,
            35.30441810344827,
            35.80280172413793,
            36.30118534482759,
            36.79956896551724,
            37.2979525862069,
            37.796336206896555,
            38.294719827586206,
            38.793103448275865,
            39.29148706896552,
            39.789870689655174,
            40.28825431034483,
            40.78663793103449,
            41.28502155172414,
            41.7834051724138,
            42.28178879310346,
            42.78017241379311,
            43.27855603448276,
            43.77693965517242,
            44.27532327586208,
            44.77370689655173,
            45.022898706896555,
            45.27209051724138,
            45.521282327586206,
            45.77047413793104,
            46.01966594827587,
            46.2688577586207,
            46.51804956896552,
            46.76724137931035,
            47.016433189655174,
            47.265625,
            47.514816810344826,
            47.76400862068966,
            48.01320043103449,
            48.26239224137932,
            48.51158405172414,
            48.76077586206897,
            49.009967672413794,
            49.25915948275862,
            49.508351293103445,
            49.75754310344828,
            50.00673491379311,
            50.255926724137936,
            50.50511853448276,
            50.75431034482759,
            51.25269396551724,
            51.7510775862069,
            52.249461206896555,
            52.747844827586206,
            53.24622844827586,
            53.744612068965516,
            54.242995689655174,
            54.741379310344826,
            55.23976293103448,
            55.738146551724135,
            56.236530172413794,
            56.734913793103445,
            57.233297413793096,
            57.731681034482754,
            58.23006465517241,
            58.728448275862064,
            59.226831896551715,
            59.725215517241374,
            60.22359913793103,
            60.72198275862068,
            61.22036637931034,
            61.71875,
            62.21713362068965,
            62.71551724137931,
            63.71228448275862,
            64.70905172413794,
            65.70581896551724,
            66.70258620689656,
            67.69935344827587,
            68.69612068965517,
            69.69288793103448,
            70.6896551724138,
            71.68642241379311,
            72.68318965517241,
            73.67995689655173,
            74.67672413793105,
            75.67349137931035,
            76.67025862068967,
            77.66702586206898,
            78.66379310344828,
            79.66056034482759,
            80.6573275862069,
            81.65409482758622,
            82.65086206896552,
            83.64762931034483,
            84.64439655172414,
            85.64116379310346,
            86.63793103448276,
            87.63469827586206,
            88.63146551724138,
            89.6282327586207,
            90.625,
            91.6217672413793,
            92.61853448275862,
            93.61530172413794,
            94.61206896551724,
            95.60883620689654,
            96.60560344827586,
            97.60237068965517,
            98.59913793103448,
            99.5959051724138,
            100.59267241379311,
            101.58943965517241,
            102.58620689655173,
            103.58297413793105,
            104.57974137931035,
            105.57650862068967,
            106.57327586206898,
            107.57004310344828,
            108.5668103448276,
            109.56357758620692,
            110.56034482758622,
            111.55711206896552,
            112.55387931034484,
            113.55064655172416,
            114.54741379310346,
            115.54418103448276,
            116.54094827586208,
            117.5377155172414,
            118.5344827586207,
            120.52801724137932,
            122.52155172413794,
            124.51508620689656,
            126.50862068965517,
            128.50215517241378,
            130.4956896551724,
            132.48922413793105,
            134.48275862068965,
            136.47629310344826,
            138.4698275862069,
            140.46336206896552,
            142.45689655172413,
            144.45043103448276,
            146.4439655172414,
            148.4375,
            150.43103448275863,
            152.42456896551727,
            154.41810344827587,
            156.41163793103448,
            158.4051724137931,
            160.39870689655174,
            162.39224137931035,
            164.38577586206895,
            166.3793103448276,
            168.37284482758622,
            170.36637931034483,
            172.35991379310346,
            174.3534482758621,
            176.3469827586207,
            178.34051724137933,
            180.33405172413796,
            182.32758620689657,
            184.32112068965517,
            186.3146551724138,
            188.30818965517244,
            190.30172413793105,
            192.29525862068965,
            194.28879310344828,
            196.28232758620692,
            198.27586206896552,
            200.26939655172413,
            202.26293103448276,
            204.2564655172414,
            206.25,
            208.24353448275863,
            210.23706896551727,
            212.23060344827587,
            214.2241379310345,
            216.21767241379314,
            218.21120689655174,
            220.20474137931035,
            222.19827586206898,
            224.19181034482762,
            226.18534482758622,
            228.17887931034483,
            230.17241379310346,
            234.1594827586207,
            238.14655172413796,
            242.1336206896552,
            246.12068965517244,
            250.10775862068968,
            254.09482758620692,
            258.0818965517242,
            262.0689655172414,
            266.0560344827586,
            270.0431034482759,
            274.03017241379314,
            278.01724137931035,
            282.00431034482756,
            285.9913793103448,
            289.9784482758621,
            293.9655172413793,
            297.95258620689657,
            301.93965517241384,
            305.92672413793105,
            309.9137931034483,
            313.9008620689656,
            317.8879310344828,
            321.875,
            325.86206896551727,
            333.83620689655174,
            341.8103448275862,
            349.7844827586207,
            357.7586206896552,
            365.73275862068965,
            373.7068965517241,
            381.6810344827586,
            389.65517241379314,
            397.6293103448276,
            405.6034482758621,
            413.57758620689657,
            421.55172413793105,
            425.53879310344826,
            429.5258620689655,
            433.5129310344828,
            437.5,
            441.48706896551727,
            445.47413793103453,
            449.46120689655174,
            453.448275862069,
            457.4353448275863,
            461.4224137931035,
            465.4094827586207,
            469.39655172413796,
            473.38362068965523,
            477.37068965517244,
            481.35775862068965,
            485.3448275862069,
            489.3318965517242,
            493.3189655172414,
            497.30603448275866,
            501.29310344827593,
            505.28017241379314,
            509.2672413793104,
            513.2543103448277,
            517.2413793103449,
            521.2284482758621,
            525.2155172413793,
            529.2025862068965,
            533.1896551724138,
            537.1767241379312,
            541.1637931034484,
            545.1508620689656,
            549.1379310344828,
            553.125,
            557.1120689655172,
            561.0991379310344,
            565.0862068965517,
            569.0732758620691,
            573.0603448275863,
            577.0474137931035,
            581.0344827586207,
            585.0215517241379,
            589.0086206896551,
            592.9956896551723,
            596.9827586206897,
            600.969827586207,
            604.9568965517242,
            608.9439655172414,
            612.9310344827586,
            616.9181034482758,
            620.905172413793,
            624.8922413793102,
            628.8793103448276,
            632.8663793103449,
            636.8534482758621,
            640.8405172413793,
            644.8275862068966,
            646.8211206896553,
            648.814655172414,
            650.8081896551726,
            652.8017241379312,
            654.7952586206898,
            656.7887931034484,
            658.782327586207,
            660.7758620689656,
            662.7693965517242,
            664.7629310344828,
            666.7564655172414,
            668.75,
            670.7435344827586,
            672.7370689655172,
            674.7306034482758,
            676.7241379310345,
            678.7176724137933,
            680.7112068965519,
            682.7047413793105,
            684.6982758620691,
            686.6918103448277,
            688.6853448275863,
            690.6788793103449,
            692.6724137931035,
            694.6659482758621,
            696.6594827586207,
            698.6530172413793,
            700.6465517241379,
            702.6400862068965,
            704.6336206896551,
            706.6271551724137,
            708.6206896551724,
            710.6142241379312,
            712.6077586206898,
            714.6012931034484,
            716.594827586207,
            718.5883620689656,
            720.5818965517242,
            722.5754310344828,
            724.5689655172414,
            726.5625,
            728.5560344827586,
            730.5495689655172,
            732.5431034482758,
            734.5366379310344,
            736.530172413793,
            738.5237068965516,
            740.5172413793103,
            741.5140086206898,
            742.5107758620691,
            743.5075431034484,
            744.5043103448277,
            745.501077586207,
            746.4978448275863,
            747.4946120689656,
            748.4913793103449,
            748.9897629310345,
            749.4881465517242,
            749.9865301724138,
            750.4849137931035,
            750.9832974137931,
            751.4816810344828,
            751.9800646551724,
            752.4784482758621,
            753.4752155172414,
            754.4719827586207,
            755.46875,
            756.4655172413793,
            757.4622844827586,
            758.4590517241379,
            759.4558189655172,
            760.4525862068965,
            761.4493534482758,
            762.4461206896551,
            763.4428879310344,
            764.4396551724137,
            765.436422413793,
            766.4331896551723,
            767.4299568965516,
            768.4267241379309,
            769.4234913793102,
            770.4202586206895,
            771.4170258620688,
            772.4137931034483,
            774.407327586207,
            776.4008620689656,
            778.3943965517242,
            780.3879310344828,
            782.3814655172414,
            784.375,
            786.3685344827586,
            788.3620689655173,
            790.355603448276,
            792.3491379310346,
            794.3426724137933,
            796.3362068965519,
            798.3297413793105,
            800.3232758620691,
            802.3168103448277,
            804.3103448275863,
            806.3038793103449,
            808.2974137931035,
            810.2909482758621,
            812.2844827586207,
            814.2780172413793,
            816.2715517241379,
            818.2650862068965,
            820.2586206896552,
            822.252155172414,
            824.2456896551726,
            826.2392241379312,
            828.2327586206898,
            830.2262931034484,
            832.219827586207,
            834.2133620689656,
            836.2068965517242,
            838.2004310344828,
            840.1939655172414,
            842.1875,
            844.1810344827586,
            846.1745689655172,
            848.1681034482758,
            850.1616379310344,
            852.1551724137931,
            854.1487068965519,
            856.1422413793105,
            858.1357758620691,
            860.1293103448277,
            862.1228448275863,
            864.1163793103449,
            866.1099137931035,
            868.1034482758621,
            870.0969827586207,
            872.0905172413793,
            874.0840517241379,
            876.0775862068965,
            878.0711206896551,
            880.0646551724137,
            882.0581896551723,
            884.051724137931,
            886.0452586206898,
            888.0387931034484,
            890.032327586207,
            892.0258620689656,
            894.0193965517242,
            896.0129310344828,
            898.0064655172414,
            900
        };


        public static double[] YValues = {
            1247265.625,
            1161679.2075664313,
            1080221.7865481253,
            1002770.888358754,
            929205.6978169009,
            859407.0544562864,
            793257.4488359896,
            730641.0188506725,
            671443.5460408046,
            615552.451902885,
            562856.7941996658,
            513247.2632703781,
            466616.1783409525,
            422857.4838342449,
            381866.74568025896,
            343541.14762637013,
            307779.4875475493,
            274482.1737565859,
            243551.22131431225,
            214890.24833982633,
            188404.47232071587,
            164000.70642328204,
            141587.35580276255,
            121074.41391355566,
            102373.45881944349,
            93675.27684907736,
            85397.64950381576,
            77529.96806991717,
            70061.72217989342,
            62982.4996972043,
            56281.986600952,
            49949.96687057562,
            43976.32237054556,
            38351.0327350581,
            33064.17525272991,
            28105.924751292438,
            23466.553482286447,
            19136.43100575655,
            15106.02407494562,
            11365.896520989289,
            7906.70913761054,
            4719.219565814019,
            1794.2821785806257,
            -877.1520344379536,
            -3304.0355822248684,
            -5495.224587703571,
            -7459.478903043302,
            -9205.462224964629,
            -10741.742210044958,
            -12076.79059002407,
            -13218.98328710957,
            -14176.600529282463,
            -14957.826965602637,
            -15570.75178151437,
            -16023.368814151876,
            -16323.576667644787,
            -16479.178828423665,
            -16497.88378052553,
            -16387.305120899393,
            -16154.961674711707,
            -15808.277610651941,
            -15354.582556238061,
            -14801.11171312205,
            -14155.005972395427,
            -13423.312029894747,
            -12612.982501507124,
            -11730.876038475753,
            -10783.757442705393,
            -9778.297782067913,
            -8721.07450570778,
            -7618.571559347589,
            -6477.179500593566,
            -5303.195614241088,
            -4102.824027580185,
            -2882.1758257010683,
            -1647.269166799627,
            841.7108319251483,
            2084.211452078652,
            3317.8248593037924,
            4536.995800293555,
            5736.261256802159,
            6910.250330339549,
            8053.684126865884,
            9161.37564148602,
            10228.229643143992,
            11249.242559317505,
            12219.502360712442,
            13134.188445957316,
            13988.571526297772,
            14778.013510291084,
            15497.967388500627,
            16143.977118190378,
            16711.677508019395,
            17196.794102736298,
            17595.143067873756,
            17902.631074443,
            18115.25518362829,
            18229.102731481376,
            18240.351213616053,
            18145.268169902574,
            17940.21106916219,
            17621.627193861597,
            17186.053524807467,
            16630.116625840896,
            15950.532528531914,
            15144.106616873973,
            14207.733511978398,
            13138.39695676892,
            11933.169700676157,
            10589.213384332068,
            9103.778424264478,
            7474.203897591538,
            3772.4350640208004,
            -535.61166923765,
            -5468.043665148818,
            -11041.560786561518,
            -24171.63449536471,
            -40031.42190761884,
            -58704.2282791277,
            -80251.19308237245,
            -104711.40807935702,
            -132102.03539445304,
            -162418.42558724518,
            -195634.2357253767,
            -213315.2883503696,
            -231701.54745739434,
            -250783.67146461122,
            -270550.9850855932,
            -290991.4830191017,
            -312091.8336388629,
            -333837.38268334453,
            -356212.156945532,
            -379198.867962705,
            -402778.91570621356,
            -426932.3922712551,
            -451638.0855666504,
            -476873.4830046196,
            -502614.7751905597,
            -528836.8596128204,
            -555513.3443324799,
            -582616.5516731226,
            -610117.5219106139,
            -637986.0169628783,
            -666190.5240796745,
            -694698.2595323736,
            -723475.1723037325,
            -752485.9477776726,
            -781694.0114290569,
            -811061.532513464,
            -840549.4277569654,
            -870117.3650459038,
            -899723.7671166658,
            -929325.8152454628,
            -958879.452938103,
            -988339.3896197717,
            -1017659.1043248044,
            -1046790.8493864647,
            -1075685.654126723,
            -1104293.3285460277,
            -1132562.4670130853,
            -1160440.4519546374,
            -1187873.4575452358,
            -1214806.453397016,
            -1241183.2082494805,
            -1266946.2936592684,
            -1292037.0876899352,
            -1316395.778601729,
            -1339961.368541367,
            -1362671.67723181,
            -1384463.3456620423,
            -1405271.8397768445,
            -1425031.4541665702,
            -1443675.315756929,
            -1461135.3874987534,
            -1477342.472057779,
            -1492226.2155044232,
            -1499149.5333591057,
            -1505715.1110035584,
            -1511913.8305472552,
            -1517736.502504293,
            -1523173.8659086982,
            -1528216.5884297383,
            -1532855.2664872203,
            -1537080.4253667989,
            -1540882.519335281,
            -1544251.9317559346,
            -1547178.9752037898,
            -1549653.8915809486,
            -1551666.8522318855,
            -1553207.9580587558,
            -1554267.2396367048,
            -1554834.6573291656,
            -1554900.1014031693,
            -1554453.3921446507,
            -1553484.2799737533,
            -1551982.4455601315,
            -1549937.4999382622,
            -1547338.9846227462,
            -1544176.3717236167,
            -1540439.0640616347,
            -1531197.6299777045,
            -1519528.523533415,
            -1505344.4846425515,
            -1488557.1556600048,
            -1469077.0850715397,
            -1446813.731183584,
            -1421675.4658129867,
            -1393569.5779768121,
            -1362402.2775821104,
            -1328078.6991156852,
            -1290502.905333885,
            -1249577.8909523725,
            -1205205.586335896,
            -1157286.8611880674,
            -1105721.5282411529,
            -1050408.346945833,
            -991245.0271609786,
            -928128.2328434398,
            -860953.5857378122,
            -789615.6690662205,
            -714008.0312180836,
            -634023.189439904,
            -549552.6335250409,
            -460486.8295034771,
            -268126.2445820186,
            -56044.82785953162,
            176670.1715481677,
            430947.5305206736,
            707731.9338600705,
            1007983.8562181438,
            1332679.4440234974,
            1682810.3974087455,
            2059383.852137636,
            2463422.261532208,
            2895963.2783999797,
            3358059.6369610527,
            3850779.034775294,
            4375204.014669511,
            4932431.846664574,
            5523574.409902563,
            6149758.074573956,
            6812123.583844798,
            7511825.935783766,
            8250034.265289441,
            9027931.72601734,
            9846715.372307226,
            10707596.041110113,
            11611798.23391547,
            12560559.998678416,
            13555132.81174687,
            14596781.459788635,
            15686783.921718597,
            16826431.250625923,
            18017027.455701165,
            19259889.3841634,
            20556346.603187412,
            21907741.281830862,
            23315428.07296145,
            24780773.99518399,
            26305158.314767607,
            27889972.427573,
            29536619.740979426,
            31246515.555811904,
            33021086.9482685,
            34861772.65184732,
            36770022.939273626,
            38747299.50442727,
            40795075.34426952,
            42914834.640770435,
            45108072.642835945,
            47376295.54823498,
            49721020.385526605,
            52143774.89598731,
            54646097.41553809,
            57229536.7566715,
            59895652.09037884,
            62646012.82807757,
            65482198.50353812,
            68405798.65481119,
            71418412.70615494,
            77717128.92868692,
            84391335.80257945,
            91454172.58193459,
            98918925.36517979,
            106799023.31673703,
            115108034.88869216,
            123859664.0424628,
            133067746.47046836,
            142746245.81779835,
            152909249.90388212,
            163570966.94415662,
            174745721.7717359,
            186447952.059081,
            198692204.5396672,
            211493131.22965395,
            224865485.64955425,
            238824119.0459027,
            253383976.61292428,
            268560093.71420467,
            284367592.1043583,
            300821676.15069675,
            317937629.0548985,
            335730809.074678,
            354216645.7454546,
            373410636.10202026,
            393328340.9002099,
            413985380.8385705,
            435397432.78002894,
            457580225.9735608,
            480549538.2758618,
            504321192.3730132,
            528911052.0021529,
            554335018.1731448,
            580609025.3902466,
            607749037.8737787,
            635771045.7817934,
            664691061.4317447,
            694525115.5221565,
            725289253.3542912,
            756999531.0538187,
            789672011.7924867,
            823322762.0097883,
            857967847.6346316,
            893623330.3070068,
            930305263.5996592,
            968029689.239754,
            1006812633.3305464,
            1046670102.5730538,
            1087618080.4877193,
            1129672523.6360838,
            1172849357.8424554,
            1217164474.4155788,
            1262633726.3702998,
            1309272924.6492386,
            1357097834.3444586,
            1406124170.9191344,
            1507843715.7451153,
            1614556146.678215,
            1726385015.3940568,
            1843452716.7862606,
            1965880368.059853,
            2093787687.8246672,
            2227292875.1887574,
            2366512488.851795,
            2511561326.1984863,
            2662552302.3919744,
            2819596329.4672413,
            2982802195.424514,
            3152276443.3226867,
            3328123250.3727093,
            3510444307.031,
            3699338696.0928493,
            3894902771.7858386,
            4097230038.863228,
            4306411031.697372,
            4522533193.373136,
            4745680754.781286,
            4975934613.711895,
            5213372213.947773,
            5458067424.357848,
            5969507551.16736,
            6510769852.3638525,
            7082304249.526779,
            7684491858.580656,
            8317641120.784062,
            8981983933.718641,
            9677671782.27813,
            10404771869.657326,
            11163263248.341145,
            11953032951.093582,
            12773872121.946762,
            13625472147.18991,
            14062682808.775856,
            14507420786.35838,
            14959617723.439468,
            15419198303.222656,
            15886080127.706377,
            16360173596.777374,
            16841381787.304142,
            17329600332.230297,
            17824717299.668,
            18326613071.991356,
            18835160224.929813,
            19350223406.661625,
            19871659216.907166,
            20399316086.02238,
            20933034154.092228,
            21472645150.024055,
            22017972270.640957,
            22568830059.77526,
            23125024287.361916,
            23686351828.531834,
            24252600542.70539,
            24823549152.685772,
            25398967123.752388,
            25978614542.754288,
            26562241997.203575,
            27149590454.368828,
            27740391140.36843,
            28334365419.264084,
            28931224672.15409,
            29530670176.266907,
            30132392984.054413,
            30736073802.28543,
            31341382871.139046,
            31947979843.298065,
            32555513663.04236,
            33163622445.342415,
            33771933354.952545,
            34380062485.5044,
            34987614738.60042,
            35594183702.90713,
            36199351533.24868,
            36802688829.70009,
            37403754516.6808,
            38002095722.04802,
            38597247656.19008,
            39188733491.11992,
            39776064239.56847,
            40358738634.07805,
            40936243006.09584,
            41508051165.06714,
            42073624277.528854,
            42632410746.203,
            43183846089.09001,
            43727352818.56204,
            44262340320.45657,
            44788204733.16977,
            45047523422.23053,
            45304328826.74974,
            45558541684.342804,
            45810081881.9901,
            46058868452.25856,
            46304819569.52341,
            46547852546.18974,
            46787883828.91434,
            47024828994.82724,
            47258602747.75339,
            47489118914.43443,
            47716290440.75012,
            47940029387.94035,
            48160246928.82648,
            48376853344.033295,
            48589758018.21042,
            48798869436.25418,
            49004095179.529144,
            49205341922.089966,
            49402515426.90268,
            49595520542.0668,
            49784261197.036865,
            49968640398.84396,
            50148560228.317474,
            50323921836.30679,
            50494625439.902954,
            50660570318.66022,
            50821654810.818085,
            50977776309.52237,
            51128831259.047485,
            51274715151.01767,
            51415322520.62891,
            51550546942.87045,
            51680281028.74664,
            51804416421.49835,
            51922843792.82489,
            52035452839.10565,
            52142132277.62137,
            52242769842.77652,
            52337252282.320435,
            52425465353.569,
            52507293819.62662,
            52582621445.607635,
            52651330994.858185,
            52713304225.17752,
            52768421885.04019,
            52816563709.81726,
            52857608417.99832,
            52875431173.90985,
            52891433707.41272,
            52905600570.637695,
            52917916251.45181,
            52928365173.3407,
            52936931695.29016,
            52943600111.668335,
            52948354652.10739,
            52950009272.87964,
            52951179481.38574,
            52951863288.070404,
            52952058699.309875,
            52951763717.40863,
            52950976340.59592,
            52949694563.02142,
            52947916374.7522,
            52942862705.960724,
            52935799172.95929,
            52926709548.92322,
            52915577541.3475,
            52902386791.92868,
            52887120876.44681,
            52869763304.64694,
            52850297520.12195,
            52828706900.19354,
            52804974755.79468,
            52779084331.35147,
            52751018804.66501,
            52720761286.793335,
            52688294821.933075,
            52653602387.30209,
            52616666893.02063,
            52577471181.99365,
            52535998029.79288,
            52492230144.538086,
            52446150166.78003,
            52346984157.39917,
            52238359770.17578,
            52120135684.96515,
            51992169489.17474,
            51854317673.98505,
            51706435630.57184,
            51548377646.327576,
            51379996901.08307,
            51201145463.32947,
            51011674286.43933,
            50811433204.888916,
            50600270930.47943,
            50378035048.55878,
            50144572014.24365,
            49899727148.64044,
            49643344635.067444,
            49375267515.27649,
            49095337685.674255,
            48803395893.54474,
            48499281733.26965,
            48182833642.55133,
            47853888898.63367,
            47512283614.52435,
            47157852735.21564,
            46790430033.90698,
            46409848108.2262,
            46015938376.45123,
            45608531073.73181,
            45187455248.310974,
            44752538757.747314,
            44303608265.1358,
            43840489235.33002,
            43363005931.16376,
            42870981409.672485,
            42364237518.31537,
            41842594891.19653,
            41305872945.28705,
            40753889876.64618,
            40186462656.6438,
            39603407028.181335,
            39004537501.913574,
            38389667352.470825,
            37758608614.680115,
            37111172079.78668,
            36447167291.67621,
            35766402543.09619,
            35068684871.877686,
            34353820057.156555,
            33621612615.59619,
            32871865797.607788,
            32104381583.57312,
            31318960680.065735,
            30515402516.072693,
            29693505239.216125,
            28853065711.975403,
            27993879507.90802,
            27115740907.871643,
            26218442896.246094,
            25301777157.154663,
            24365534070.686035,
            23409502709.11487,
            22433470833.12561,
            21437224888.03186,
            20420550000
        };
    }
}
