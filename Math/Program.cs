using System;
using System.Xml;


namespace Math
{
    public class Program
    {
        public const int Twenty = 20, Tenth= 10, Thirty = 30;
        
        public static int doMath(DataInfo data) {
            if (data.Oper.Equals("SUM")) {
                return data.ValueOne + data.ValueTwo;
            }
            if (data.Oper.Equals("MULTIPLY"))
            {
                return data.ValueOne * data.ValueTwo;
            }
            if (data.Oper.Equals("SUB"))
            {
                return data.ValueOne - data.ValueTwo;
            }

            if (data.Oper.Equals("DIVIDE"))
            {
                return data.ValueOne / data.ValueTwo;
            }
            else
                return -999999;

        }
        public static string getOperater(string op) {
            if (op.Equals("SUM"))
                return "+";
            else if (op.Equals("MULTIPLY"))
                return "*";
            else if (op.Equals("SUB"))
                return "-";
            else if (op.Equals("DIVIDE"))
                return "/";
            else
                return "Invalid Operator";
        }

        public static string printResult(DataInfo info,  int result) {

            // translate the operator from string to valuld char,
            // "+" for SUM, "-" for SUB, "*" for MULTIPLY, "/" for DIVIDE
            string op = getOperater(info.Oper);

            string ans = info.Name + "--" + info.Oper + ":  " +  info.ValueOne + " "+ op + " " + info.ValueTwo + " = "+ result ;
            
            return ans;
        }
       
        public static void Main(string[] args)
        {
             XmlDocument doc = new XmlDocument();
          // DataInfo recordInfo = new DataInfo();
            string description;
            string readValue;
            int v1;
            int v2;
            int mathResult;
            doc.Load("math.xml");
           // doc.Save(Console.Out);
            XmlTextReader xtr = new XmlTextReader("math.xml");
            DataInfo recordInfo = new DataInfo();
            Console.WriteLine();
            while (xtr.Read()) {
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Description") {
                    description = xtr.ReadElementString();
                   // store description to temperate list seperate by ","
                    string[] temp = description.Split(';');
                    recordInfo.Name = temp[0];
                    // cast out the string as proper operator
                    if (temp[1].Equals("SUM41"))
                        temp[1] = "SUM";
                    recordInfo.Oper = temp[1];

                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Value1")
                {
                    readValue = xtr.ReadString();
                    if (readValue != "Twenty")
                    {
                        // convent v1 from string to int
                        Int32.TryParse(readValue, out v1);
                    }
                    else
                        v1 = Twenty;
                    recordInfo.ValueOne = v1;
                }
                if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "Value2")
                {
                    // convent v2 from string to int
                    Int32.TryParse(xtr.ReadString(), out v2);
                    recordInfo.ValueTwo = v2;

                    // calculations the user's input two number with input Operator from XML
                    mathResult = doMath(recordInfo);
                    
                    //print out or display the result to user with proper format.
                    string printOut = printResult(recordInfo, mathResult);
                    Console.WriteLine(printOut);
                }
               

            }
            // Closes the window when the user presses ENTER
            Console.ReadLine();

       
        }
    }
}
