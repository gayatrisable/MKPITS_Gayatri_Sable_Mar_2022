//write a c program to check a given array of integer and return true if the value 5 appears 5 times and there are no 5 next to each other.  
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
		if(a[i]==5)
		{
			count=count+1;
		}
	}
	printf("%d",count);
}
