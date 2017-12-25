#include<stdio.h>
#include<math.h>
typedef int bool;
#define true 1
#define false 0


bool Prime(int totest)
{
   if( totest % 2 == 0) return false;
   for(int i = 3; i < sqrt(totest); i += 2)
   {
      if(totest % i == 0) return false;
   }
   return true;
}

int main()
{
   for(int i = 10000000; i < 10010000; i++)
   {
      if( Prime(i) == true)
      {
         printf("%d \n",i);
      }
   }
}
