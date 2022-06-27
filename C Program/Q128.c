//write a c program to check  a given array of integer and if there is a 3 with a 5 somewere later in the given array.
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
		if(a[i]==3 || a[i+1]==3 ||a[i]==5)
		{
			printf("true");
		}
		else
		{
			printf("false");
		}
	}

}
