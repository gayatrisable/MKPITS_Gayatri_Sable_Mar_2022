#include<stdio.h>
#include<conio.h>
int main()
{
	int nodays,days,weeks,years;
	printf("Enter total days=");
	scanf("%d",&nodays);
	years=nodays/365;
	weeks=(nodays%365)/7;
	days=(nodays%365)%7;
	printf("years=%d\n",years);
	printf("weeks=%d\n",weeks);
	printf("days=%d",days);
}