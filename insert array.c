#include<stdio.h>
#include<conio.h>
int main()
{
	int a[6],i,n;
	printf("Enter 5 array elements: ");
	for(i=0;i<5;i++)
	scanf("%d",&a[i]);
	printf("\n Enter elements to Insert: ");
	scanf("%d",&n);
	printf("\n The new array is: \n");
	for(i=0;i<6;i++)
		printf("%d",a[i]);
}