using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Kwnn
{
    public class kwnnConverter
    {

        public class DATA
        {
            public double Xarray { get; set; }
            public double Yarray { get; set; }
            public double w { get; set; }
            public double distance { get; set; }
        }

        public static List<DATA> list1 = new List<DATA>();

        public class KWNN
        {
            public void addAPs()
            {
                Kwnn.kwnnConverter.list1.Add(new Kwnn.kwnnConverter.DATA
                {
                    Xarray = 0,
                    Yarray = 0,
                    distance = 4,
                    w = 0,
                });
                Kwnn.kwnnConverter.list1.Add(new Kwnn.kwnnConverter.DATA
                {
                    Xarray = 0,
                    Yarray = 10,
                    distance = 8,
                    w = 0,
                });
                Kwnn.kwnnConverter.list1.Add(new Kwnn.kwnnConverter.DATA
                {
                    Xarray = 10,
                    Yarray = 0,
                    distance = 12,
                    w = 0,
                });
                Kwnn.kwnnConverter.list1.Add(new Kwnn.kwnnConverter.DATA
                {
                    Xarray = 10,
                    Yarray = 10,
                    distance = 8,
                    w = 0,
                });
                Kwnn.kwnnConverter.list1.Add(new Kwnn.kwnnConverter.DATA
                {
                    Xarray = 0,
                    Yarray = 0,
                    distance = 0,
                    w = 0,
                });
            }

            public void GW()
            {
                double sumd = 0;
                for (int i = 0; i < 4; i++)
                {
                    sumd += list1[i].distance;
                }
                for (int i = 0; i < 4; i++)
                {
                    list1[i].w = list1[i].distance / sumd;
                }
            }

            public void Locate()
            {
                for (int i = 0; i < 4; i++)
                {
                    list1[4].Xarray += list1[i].w * list1[i].Xarray;
                    list1[4].Yarray += list1[i].w * list1[i].Yarray;
                }
            }
        }
    }
}
