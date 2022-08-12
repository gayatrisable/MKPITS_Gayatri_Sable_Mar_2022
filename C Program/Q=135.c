//write a C program to create a nw array taking the elements before the elements value 5 from given array of integer.(after that 5 of an integer given array is break)
#include<stdio.h>
#include<conio.h>
int main()
{
	int i,len,a[10];
	printf("enter array size: ");
	scanf("%d",&len);
	printf("enter array element\n");
	for(i=0;i<len;i++)
	{
		scanf("%d",&a[i]);
	}
	printf("new array\n");
	for(i=0;i<len;i++)
	{
		if(a[i]==5)
		{
			break;
		}
		printf("%d\n",a[i]);
	}

}