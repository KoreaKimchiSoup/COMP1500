using System;
using System.Diagnostics;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            string minifiedList = "Week 1_Course Explanation/it's fun/it's awesome_Hello World_Types of Programming Languages|Week 2_Console output_Variables_Primitive Types|Week 3_Casting_Operator_String_Console input";

            string list = Lab8.PrettifyListOrNull(minifiedList);
            Console.WriteLine(list);

            // 위 함수에서 반환하는 list는 다음과 같습니다. 아래에서 . 문자는 빈칸 문자를 나타냅니다.
            /*
            1).Week 1
            ....a).Course Explanation
            ........-.it's fun
            ........-.it's awesome
            ....b).Hello World
            ....c).Types of Programming Languages
            2).Week 2
            ....a).Console output
            ....b).Variables
            ....c).Primitive Types
            3).Week 3
            ....a).Casting
            ....b).Operator
            ....c).String
            ....d).Console input

            */
            minifiedList = "Apple///|Orange/asdf";
            list = Lab8.PrettifyListOrNull(minifiedList);
            Console.WriteLine(list);

            /*
            1).Apple///
            2).Orange/asdf

            */

            minifiedList = "Apple|Orange/Blah_mah_nay|";
            list = Lab8.PrettifyListOrNull(minifiedList);
            Console.WriteLine(list);

            // 위 함수에서 반환하는 list는 다음과 같습니다. 아래에서 . 문자는 빈칸 문자를 나타냅니다.
            /*
            1).Apple
            2).Orange/Blah
            ....a).mah
            ....b).nay
            3).

            */

            minifiedList = "Apple|Orange/Blah_mah_nay_34_21_76_23_12_87_21_32_56_88_93_72_58_20_33_42_77_12_07_32_55_61_bah_yay_hey_heh_afd_hgf_rte_fds_ret_uyr|";
            list = Lab8.PrettifyListOrNull(minifiedList);
            Console.WriteLine(list);

            // 위 함수에서 반환하는 list는 다음과 같습니다. 아래에서 . 문자는 빈칸 문자를 나타냅니다. (너무 긴 부분은 예시에서 생략되었습니다)
            /*
            1).Apple
            2).Orange/Blah
            ....a).mah
            ....b).nay
            (중략..)
            ....y).bah
            ....z).yay
            ....aa).hey
            ....bb).heh
            (중략..)
            3).

            */
        }
    }
}
