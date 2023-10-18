 #include<stdio.h>
 void main()
 {
 	float basic_salary;
 	float hra,da,total_salary;
 	printf("Enter basic salary");
 	scanf("%f",&basic_salary);
 	hra=basic_salary*0.34f;
 	da=basic_salary*0.45;
 	total_salary=basic_salary+hra+da;
 	printf("hra=%f",hra);
 	printf("/nda=%f",da);
 	printf("/ntotal_salary=%f",total_salary);
 }
