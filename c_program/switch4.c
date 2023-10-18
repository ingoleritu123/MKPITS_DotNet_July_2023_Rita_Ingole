#include<stdio.h>
void main()
{
	char ch;
	printf("enter character:");
	scanf("%c",&ch);
	
	switch(ch)
	{
		case 'a':
		case 'e':
		case 'i':
		case 'o':
		case 'u':
			printf("it is vowel.");
			break;
		default:
			printf("it is consonent.");
			break;
	}
}
