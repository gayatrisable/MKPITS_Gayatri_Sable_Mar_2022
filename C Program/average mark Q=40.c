#include<stdio.h>
#include<conio.h>
int main()
{
	int mark[99],c,i,a=0,t=0;
	float f;
	printf("Enter mathematics marks:");
	for(i=0; ;i++)
	{
		scanf("%d",&mark[i]);
		if(mark[i]<=0)
		{
			break;
		}
		a++;
		t+=mark[i];
	 } 
	 f=(float)t/(float)a;
	 printf("Average marks in mathematics:%.2f\n",f);

}