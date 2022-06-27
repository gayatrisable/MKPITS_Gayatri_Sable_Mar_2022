//write a c program to check a given array of integer and return true if the given array contains two 5's next  to each other or two separated by one element. 
#include<stdio.h>
#include<stdio.h>
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
		if(a[i]==5 || a[i+1]==5)
		{
			printf("true");
		}
		else
		{
			printf("false");
		}
	}

}
