'''
수 정렬하기
 
시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
1 초	128 MB	112809	64279	44437	58.364%
문제
N개의 수가 주어졌을 때, 이를 오름차순으로 정렬하는 프로그램을 작성하시오.

입력
첫째 줄에 수의 개수 N(1 ≤ N ≤ 1,000)이 주어진다. 둘째 줄부터 N개의 줄에는 수 주어진다. 이 수는 절댓값이 1,000보다 작거나 같은 정수이다. 수는 중복되지 않는다.

출력
첫째 줄부터 N개의 줄에 오름차순으로 정렬한 결과를 한 줄에 하나씩 출력한다.

예제 입력 1 
5
5
2
3
4
1
예제 출력 1 
1
2
3
4
5
출처
문제의 오타를 찾은 사람: lazy_ren
비슷한 문제
2751번. 수 정렬하기 2
10989번. 수 정렬하기 3
알고리즘 분류
구현
정렬
'''

'''

N = int(input())
arr=[]

for i in range(N): # N만큼 반복
    arr.append(int(input())) #리스트에 N개의 수 저장

arr.sort() # sort() 함수로 정렬

for x in range(N):
               print(arr[x]) # 정렬된 리스트 출력
    
'''

'''
N = int(input())
arr=[]

for i in range(N): # N만큼 반복
    arr.append(int(input())) #리스트에 N개의 수 저장

#버블정렬
for i in range(len(arr)):
    for j in range(len(arr)):
        if arr[i]<arr[j]:
            arr[i], arr[j] = arr[j], arr[i]

for x in arr:
    print(x)
'''

N=int(input())
arr=[]

for i in range(N):
    arr.append(int(input()))

for i in range(1,len(arr)):
    while (i>0 & (arr[i] < arr[i-1])) :
        arr[i], arr[i-1] = arr[i-1], arr[i]

        i-=1

for x in arr:
    print(x)
