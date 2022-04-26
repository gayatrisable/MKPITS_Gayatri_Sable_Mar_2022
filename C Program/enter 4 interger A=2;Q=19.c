#include<stdio.h>
#include<conio.h>
int main()
{
	int p,q,r,s;
	printf("Enter the 1st Integer:");
	scanf("%d",&p);
	printf("Enter the 2nd Integer:");
	scanf("%d",&q);
	printf("Enter the 3rd Integer:");
	scanf("%d",&r);
	printf("Enter the 4th Integer:");
	scanf("%d",&s);
	if((r>0)&&(s>0)&&(p%2==0)&&(q>r)&&(s>p)&&((r+s)>(p+q)))
	{
	
		printf("Correct value\n");
	}
	else
	printf("wrong values\n");
}