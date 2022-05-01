#include<stdio.h>
#include<conio.h>
int main()
{
 int a;
 printf("Enter the number between 1 to 12 to get the month name:");
 scanf("%d",&a);
 switch(a)
 {
 	case 1:printf("Januay\n");break;
 	case 2:printf("February\n");break;
 	case 3:printf("March\n");break;
 	case 4:printf("April\n");break;
 	case 5:printf("May\n");break;
 	case 6:printf("June\n");break;
 	case 7:printf("July\n");break;
 	case 8:printf("Augest\n");break;
 	case 9:printf("September\n");break;
 	case 10:printf("October\n");break;
 	case 11:printf("November\n");break;
 	case 12:printf("December\n");break;
 	default :printf(" month is not between 1 to 12 \n");break;
	 }	
	}