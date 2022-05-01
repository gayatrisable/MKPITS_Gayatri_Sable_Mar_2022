#include<stdio.h>
#include<conio.h>
int main()
{
 int x,y,temp,i,sum=0;
 printf("Enter the 1st integer:");
 scanf("%d",&x);
 printf("Enter the 2nd integer:");
 scanf("%d",&y);
 if(x>y)
 {
 temp=y;
 y=x;
 x=temp;
	 }
	 for(i=x+1;i<y;i++)
	 {
	 	if((i%7)==2 || (i%7)==3)
		 {
	 		printf("%d\n",i);
		 }
	 }
	}

