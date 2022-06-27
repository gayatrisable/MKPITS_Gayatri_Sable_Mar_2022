//Write a c program to check wether a given array of integers contains 5's and 7's. 
#include<stdio.h>
#include<conio.h>
main()
{
	int a[5],i,count=0;
	printf("enter array elements a;");
	for(i=0;i<5;i++)
	{
		printf("a[%d]=",i);
		scanf("%d",&a[i]);	
	}	
	for(i=0;i<5;i++)
	{
		if(a[i]==5 || a[i+1]==5 || a[i+1]==7)
		{
			count=count+1;
		}
	}
	printf("%d",count);
}
