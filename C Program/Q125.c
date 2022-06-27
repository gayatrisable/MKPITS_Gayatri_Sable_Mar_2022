//write a c program to check if a given array of integers contains a 3 or a 5.
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
		if(a[i]==3 || a[i]==5)
		{
			count=count+1;
		}
	}
	printf("%d",count);
}
