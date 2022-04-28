#include<stdio.h>
#include<conio.h>
int main()
{
  int a[3];
  int i;
  printf("enter 3 number");
  for(i=0;i<=2;i++)
  {
  	printf("a[%d]=",i);
  	scanf("%d",&a[i]);
  }
  for(i=0;i<=2;i++)
  {
  	printf("[%d]=%d",i,a[i]);
  }
}