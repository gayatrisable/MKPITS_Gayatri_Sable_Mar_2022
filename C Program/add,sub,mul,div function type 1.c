#include<stdio.h>
#include<conio.h>
void add();
void sub();
void mul();
void div();
void main()
{
	add();
	sub();
	mul();
	div();
} 
void add()
 {
 	printf("Addition\n");
 	int a,b,add;
 	printf("Enter the value of a\n");
 	scanf("%d",&a);
 	printf("Enter the value of a\n");
 	scanf("%d",&b);
 	add=a+b;
 	printf("addition of a and is %d\n",add);
 	 }
void sub()
{
	printf("Substration\n");
	int a,b,sub;
	printf("Enter the value of a\n"); 	
	scanf("%d",&a);
 	printf("Enter the value of a\n");
 	scanf("%d",&b);
    sub=a-b;
   printf("Substratin of a and is %d\n",sub);
}
void mul()
{
	printf("multiplication\n");
	int a,b,mul;
	printf("Enter the value of a\n"); 	
	scanf("%d",&a);
 	printf("Enter the value of a\n");
 	scanf("%d",&b);
    mul=a*b;
   printf("Multiplicatin of a and is %d\n",mul);
}
void div()
{
printf("Division\n");
 	int a,b,div;
 	printf("Enter the value of a\n");
 	scanf("%d",&a);
 	printf("Enter the value of a\n");
 	scanf("%d",&b);
 	div=a/b;
 	printf("addition of a and is %d\n",div);	
}