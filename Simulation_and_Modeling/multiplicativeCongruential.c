#include <stdio.h>
int main()
{
         int x[10000], a, c, m, i, j, flag=0;
         printf("Enter the value of seed (X0)~ ");
         scanf("%d", &x[0]);
         printf("\nEnter the value of multiplier (a)~ ");
         scanf("%d", &a);
         printf("\nEnter the value of incrementer (c)~ ");
         scanf("%d", &c);
         printf("\nEnter the value of modulo (m)~ ");
         scanf("%d", &m);

         for(i=0; flag==0; i++){
                  printf("x[%d]= %d\n",i, x[i]);
                  x[i+1]=((a*x[i])%m);

                  for(j=0; j<=i; j++){
                           if(x[i+1]==x[j]){
                                    flag=1;
                           }
                  }

         }

         printf("x[%d]= %d", i+1, x[i+1]);
         return 0;
}