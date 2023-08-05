#include<stdio.h>
#include<string.h>
struct Book
{
	char title[50];
	char author[50];
	int bookid;
};
void main()
{
	struct Book b1;
	printf("Enter Title, Author, Book id :\n ");
	scanf("%s%s%d",b1.title,b1.author,&b1.bookid);
	printf("Title = %s",b1.title);
	printf("\nAuthor = %s",b1.author);
	printf("\nBook id = %d",b1.bookid);
}

//ALGORITHM
//1.start
//2.define function struct book
//3.declare title,author,bookid
//4.go to main function 
//5.call function struct book b1
//6.Accept title,author,book,id
//7.print title,author,bookid
//8.stop
