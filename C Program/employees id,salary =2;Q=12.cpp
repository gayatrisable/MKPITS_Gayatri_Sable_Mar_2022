#include<stdio.h>
#include<conio.h>
int main()
{
	char id[20];
	int hour;
	double amount,salary;
	printf("Enter the Employees Id:");
	scanf("%s",&id);
	printf("\nEnter the working hours:");
	scanf("%d",&hour);
	printf("\nSalary value/hrs:");
	scanf("%if",&amount);
	salary=amount*hour;
	printf("\nEmloyees Id=%s \nSalary=%iRs",id,salary);
}