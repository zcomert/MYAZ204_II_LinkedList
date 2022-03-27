using DataStructures.LinkedList.DoublyLinkedList;
using System;
using System.Collections.Generic;
using Xunit;

namespace LinkedListTest
{
    public class LinkedListTests
    {
        // Bu testin ge�mesini sa�lay�n�z.
        [Fact]
        public void Traverse_in_DoublyLinkedList()
        {
            // Bu testing ge�mesi i�in
            // Tail -> Head do�ru hareket edilmesini sa�layan
            // DoublyLinkedListReverseEnumerator.cs s�n�f�n�n implemente edilmesi beklenmektedir.

            // Arrange & Act
            var linkedList =
                new DoublyLinkedList<int>(new int[] { 10, 20, 30, 40, 50 });

            // Assert
            Assert.Collection(linkedList,
                item => Assert.Equal(50, item),
                item => Assert.Equal(40, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(10, item));
        }

        [Fact]
        public void AddLast_Test()
        {
            // Bu testing ge�mesi i�in DoublyLinkedList.cs s�n�f� i�erisindeki
            // AddLast(DbNode<T> newNode) imzal� d���m� implemente etmeniz beklenmektedir.

            // Assert
            var linkedList = new DoublyLinkedList<int>(new List<int> { 10, 20, 30 });

            // Act
            var newNode = new DbNode<int>(23);
            linkedList.AddLast(newNode);

            // Assert
            Assert.Collection(linkedList,
                item => Assert.Equal(23, item),
                item => Assert.Equal(30, item),
                item => Assert.Equal(20, item),
                item => Assert.Equal(10, item));
        }
    }
}
