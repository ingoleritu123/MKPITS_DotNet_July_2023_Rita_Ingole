#include<stdio.h>
int main()
{
int M1,M2,M3,total;
float per;
printf("enter 3 sub marks")	;
scanf("%d,%d,%d",&M1,&M2,&M3);
total=M1+M2+M3;
per=((total/300.0f)*100.0f);
if(per>=75)
{
	printf("grade=destinction");
}
else if("per>60 && per>75")
{
	printf("grade=first");
}
else if(per>=40 && per<60)
{
	printf("grade=second");
}
else
{
	printf("grade=fail");
}
return 0;
}
