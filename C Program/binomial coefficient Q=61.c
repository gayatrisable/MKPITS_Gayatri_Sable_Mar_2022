#include<stdio.h>
#include<conio.h>
void main()
{
	int n,r,fact=1,fact2=1,coeff,i,j;
	for(n=0;n<=10;n++)
	{
		for(r=0;r<=n;r++)
		{
		for(i=n;i>r;i--)
		{
			fact=fact*i;
		}
		for(j=n-r;j>=1;j--)
		{
			fact2=fact2*j;
		}
		coeff=fact/fact2;
		printf("%d ",coeff);
		if(n==r)
		printf("\n");
		fact=1;
		fact2=1;
	}
}
}