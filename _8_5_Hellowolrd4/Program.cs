using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MonsterInfo;
using CharaterInfo;

namespace Hellowolrd4
{
    class Solution
    {
        public int solution(int n)
        {
            int answer = n+1;
            int num = n;
            int cnt=0;  //2진수 1의개수 카운트
            int cntt;   //2진수 1의개수 카운트(cnt와 대조용)

            while (num != 0)     //2진수 1의개수 세기
            {
                cnt += num%2;
                num/=2;
			}

            while(true)
			{
                cntt = 0;           //cntt와 num값 초기화
                num = answer;
                while (num != 0)    //2진수 1의개수 세기
                {
                    cntt += num%2;
                    num/=2;
                }
                if (cntt==cnt)      //1의 갯수가 동일할경우 break
                    break;
                answer++;           //아닐경우 answer+1 후 다시 처음으로
            }

            return answer;
        }
    }


}