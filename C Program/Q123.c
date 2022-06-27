//write a c program to check if the sum of all 5 in the array  exactly  15 in given array of integer.
#include<stdio.h>
#include<conio.h>
main()
{
	int a[5],i,add=0;
	printf("enter the value :");
	for(i=0;i<5;i++)
	{
		printf("a[%d]=",i);
		scanf("%d",&a[i]);
	}
	for(i=0;i<5;i++)
	{
		if(a[i]==5)
		{
			add=add+a[i];
		}
		
	}
	printf("%d",add);
}
