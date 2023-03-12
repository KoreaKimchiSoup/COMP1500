using System;
using System.Text;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string minifiedList = "Week 1_Course Explanation/it's fun/it's awesome_Hello World_Types of Programming Languages|Week 2_Console output_Variables_Primitive Types|Week 3_Casting_Operator_String_Console input";

            string list = Lab8.PrettifyListOrNull(minifiedList);
            Console.WriteLine(list);

            minifiedList = "Apple///|Orange/asdf";
            list = Lab8.PrettifyListOrNull(minifiedList);
            Console.WriteLine(list);

            minifiedList = "Apple|Orange/Blah_mah_nay|";
            list = Lab8.PrettifyListOrNull(minifiedList);
            Console.WriteLine(list);

            minifiedList = "Apple|Orange/Blah_mah_nay_34_21_76_23_12_87_21_32_56_88_93_72_58_20_33_42_77_12_07_32_55_61_bah_yay_hey_heh_afd_hgf_rte_fds_ret_uyr|";
            list = Lab8.PrettifyListOrNull(minifiedList);
            Console.WriteLine(list);
        }
    }
}
