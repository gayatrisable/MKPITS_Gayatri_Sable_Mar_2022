#include<stdio.h>
#include<conio.h> 
void main()
{
	char gs;
	printf("list of integer equivalents of letter\n");
	printf("Small letter's interger\n");
	for(gs='a';gs<='z';gs++)
	{
		printf("%d\n",gs);
	}
	printf("capital letter's integer\n");
	for(gs='A';gs<='Z';gs++)
	{
		printf("%d\n",gs);
	}
}