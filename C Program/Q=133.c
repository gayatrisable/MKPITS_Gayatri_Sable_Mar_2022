//Write a C program to check a given array  of integer  and return true if  the array  of integer and return true if  the array contains  three increasing adjacent nmber
#include<stdio.h>
#include<conio.h>
int main()
{
	int i,a[10],size,f=0;
	printf("enter the size of array: ");
	scanf("%d",&size);
	printf("enter array element\n");
	for(i=0;i<size;i++)
	{
		scanf("%d",&a[i]);
	}
	for(i=0;i<size;i++)
	{
		if(a[i+1]>a[i]&&a[i+2]>a[i+1])
		{
			f=1;
		}
	}
	if(f==1)
	{
		printf("true");
	}
	else
	{
		printf("false");
	}
}