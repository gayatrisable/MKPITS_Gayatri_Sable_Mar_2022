#include<stdio.h>
#include<conio.h>
int main()
{
	int sec,h,m,s;
	printf("Input second:");
	scanf("%d",&sec);
	h=(sec/3600);
	m=(sec/(3600*h))/60;
	sec=(sec-(3600*h)-(m*60));
	printf("H:M:S-%d:%d:%d\n",h,m,s);
}