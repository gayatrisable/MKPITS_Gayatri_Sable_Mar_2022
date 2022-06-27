//write a  c program to check if a given array of integer contains 5 next to 5 somewere.
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
			count=count+1;
		}
	}
	printf("%d",count);
}
