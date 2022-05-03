#include<stdio.h>
#include<conio.h>
 int main()
 {
 	int num,n1,add=0;
 	printf("Enter number:");
 	scanf("%d",&num);
 	while(num>0)
	 {
	if(num>0 && num<1000)
	{
	n1=num%10;
	add=add+n1;
	num=num/10;
 }
}
   printf("Sum of digit is %d\n",add);
 }