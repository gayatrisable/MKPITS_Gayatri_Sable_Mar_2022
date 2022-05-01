#include<stdio.h>
#include<conio.h>
int main()
{
	int a,b;
	printf("Enter the value X and Y coordinate:");
	scanf("%d%d",&a,&b);
	if(a>0&&b>0)
	printf("The coordinate point(%d%d)lies in the 1st quadrant.\n",a,b);
	else if(a<0&&b>0)
	printf("The coordinate point(%d%d)lies in the 2nd quadrant.\n",a,b);
	else if(a<0&&b<0)
	printf("The coordinate point(%d%d)lies in the 3rd quadrant.\n",a,b);
	else if(a>0&&b<0)
	printf("The coordinate point(%d%d)lies in the 4th quadrant.\n",a,b);
	else if(a==0&&b==0)
	printf("The coordinate point(%d%d)lies at orgin.\n",a,b);
}