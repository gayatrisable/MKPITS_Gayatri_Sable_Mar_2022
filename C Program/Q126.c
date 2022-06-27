//write a c program to check if an array of integers contains a 3 next to a 5 next to a 5 or both.
#include<stdio.h>
#include<conio.h>
main()
{
	int a[5],i,count=0;
	printf("enter 5 array elements :");
	for(i=0;i<5;i++)
	{
		printf("a[%d]=",i);
		scanf("%d",&a[i]);
	}
	for(i=0;i<5;i++)
	{
		if(a[i]==3 || a[i+1]==3|| a[i]==5 || a[i+1]==5)
		{
			count=count+1;
		}
	}
	printf("%d",count);
}
