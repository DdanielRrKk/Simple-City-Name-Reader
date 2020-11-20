using System;
using System.Collections.Generic;
using System.Linq;

namespace Cities
{
    public class City_Name
    {
        private string cities;

        private static int count = 0;

        public string getCities()
        {
            return cities;
        }

        

        public string setBGName(string s)
        {
            bool errorFlag = false;

            if (count < 3)
            {
                foreach (char c in s)
                {
                    if (c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я' || char.IsControl(c) || c == '-')
                    {

                    }
                    else
                    {
                        errorFlag = true;
                    }
                }

                if (errorFlag == false)
                {
                    cities = cities + " " + s;
                    count++;
                }
            }

            return cities;
        }

        public string setGBName(string s)
        {
            bool errorFlag = false;

            if (count < 3)
            {
                foreach (char c in s)
                {
                    if (c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я')
                    {
                        errorFlag = true;
                    }
                    else
                    {

                    }
                }

                if (errorFlag == false)
                {
                    cities = cities + " " + s;
                    count++;
                }
            }

            return cities;
        }

        public string uppercase()
        {
            string temp = "";

            if (!string.IsNullOrEmpty(cities))
            {
                temp = cities.Substring(0, 1).ToUpper();

                for (int i = 1; i < cities.Length; i++)
                {
                    if (cities.Substring(i - 1, 1) == " ")
                    {
                        temp = temp + cities.Substring(i, 1).ToUpper();
                    }
                    else
                    {
                        temp = temp + cities.Substring(i, 1);
                    }
                }

            }

            cities = temp;
            return temp;
        }

        public string checkSpace()
        {
            string temp = "";

            if (!string.IsNullOrEmpty(cities))
            {
                temp = cities.Substring(0, 1);

                for (int i = 1; i < cities.Length; i++)
                {
                    if (cities.Substring(i - 1, 1) == " " && cities.Substring(i, 1) == " ")
                    {
                       
                    }
                    else
                    {
                        temp = temp + cities.Substring(i, 1);
                    }
                }

            }

            cities = temp;
            return temp;
        }

        public string deleteLastCity()
        {
            string temp = "";

            if (!string.IsNullOrEmpty(cities))
            {
                for(int i=0; i < cities.LastIndexOf(" "); i++)
                {
                    temp = temp + cities.Substring(i, 1);
                }
            }

            cities = temp.Trim();
            return temp;
        }

        public string deleteFirstCity()
        {
            string temp = "";

            if (!string.IsNullOrEmpty(cities))
            {
                for (int i = cities.LastIndexOf(" "); i < cities.Length; i++)
                {
                    temp = temp + cities.Substring(i, 1);
                }
            }

            cities = temp.Trim();
            return temp;
        }

        public string removeFirstLines()
        {
            string temp = "";

            if (!string.IsNullOrEmpty(cities))
            {

                string[] strArr = cities.Split(' ');
                

                foreach(string c in strArr)
                {
                    string temptemp = c;
                    bool flag = false;

                    while (flag == false)
                    {
                        if (temptemp.StartsWith("-"))
                        {
                            temptemp = temptemp.Substring(1);
                        }
                        else
                        {
                            flag = true;
                        }
                    }

                    if (temp == "")
                    {
                        temp = temp + temptemp;
                    }
                    else
                    {
                        temp = temp + " " + temptemp;
                    }
                }

            }

            cities = temp;
            return temp;
        }

        public string removeMiddleLines()
        {
            string temp = "";

            if (!string.IsNullOrEmpty(cities))
            {
                temp = cities.Substring(0, 1);

                for (int i = 1; i < cities.Length; i++)
                {
                    if (cities.Substring(i - 1, 1) == "-" && cities.Substring(i, 1) == "-")
                    {

                    }
                    else
                    {
                        temp = temp + cities.Substring(i, 1);
                    }
                }

            }

            cities = temp;
            return temp;
        }

        public string removeLastLines()
        {
            string temp = "";

            if (!string.IsNullOrEmpty(cities))
            {

                string[] strArr = cities.Split(' ');


                foreach (string c in strArr)
                {
                    string temptemp = c;
                    bool flag = false;

                    while (flag == false)
                    {
                        if (temptemp.EndsWith("-"))
                        {
                            int size = temptemp.Length;
                            temptemp = temptemp.Substring(0, size - 1);
                        }
                        else
                        {
                            flag = true;
                        }
                    }

                    if (temp == "")
                    {
                        temp = temp + temptemp;
                    }
                    else
                    {
                        temp = temp + " " + temptemp;
                    }
                }

            }

            cities = temp;
            return temp;
        }



    }
}
