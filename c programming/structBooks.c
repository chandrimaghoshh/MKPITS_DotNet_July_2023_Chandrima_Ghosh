#include<stdio.h>
#include<string.h>
struct Book{
	char title[50];
	char author[50];
	int bookid;
};
void main()
{
	struct Book b1;
	strcpy(b1.title,"Dotnet");
	strcpy(b1.author,"Chandrima");
	b1.bookid=123;
	printf("Title = %s",b1.title);
	printf("\nAuthor = %s",b1.author);
	printf("\nBook id = %d",b1.bookid);
}
