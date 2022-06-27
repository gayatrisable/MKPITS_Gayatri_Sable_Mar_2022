//write a c program to check a given array of integer and return true if the given array contains either  2 even or 2 odd values all next to each other.
#include<stdio.h>
#include<conio.h>
main()
{
	int a[5],i;
	printf("enter 5 array elements");
	for(i=0;i<5;i++)
	{
		printf("a[%d]=",i);
		scanf("%d",&a[i]);
	}
	for(i=0;i<5;i++)
	{
		if(a[i]%2==0 || a[i+1]%2==0 ||a[i]%2!=0 || a[i+1]%2!=0)
		{
			printf("true");
		}
		else
		{
			printf("false");
		}
		
	}
}
