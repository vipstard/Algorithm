'''
22.01.04
상수 다국어
 
시간 제한	메모리 제한	제출	정답	맞힌 사람	정답 비율
1 초	128 MB	69387	47949	41740	69.680%
문제
상근이의 동생 상수는 수학을 정말 못한다. 상수는 숫자를 읽는데 문제가 있다. 이렇게 수학을 못하는 상수를 위해서 상근이는 수의 크기를 비교하는 문제를 내주었다. 상근이는 세 자리 수 두 개를 칠판에 써주었다. 그 다음에 크기가 큰 수를 말해보라고 했다.

상수는 수를 다른 사람과 다르게 거꾸로 읽는다. 예를 들어, 734와 893을 칠판에 적었다면, 상수는 이 수를 437과 398로 읽는다. 따라서, 상수는 두 수중 큰 수인 437을 큰 수라고 말할 것이다.

두 수가 주어졌을 때, 상수의 대답을 출력하는 프로그램을 작성하시오.

입력
첫째 줄에 상근이가 칠판에 적은 두 수 A와 B가 주어진다. 두 수는 같지 않은 세 자리 수이며, 0이 포함되어 있지 않다.

출력
첫째 줄에 상수의 대답을 출력한다.

예제 입력 1 
734 893
예제 출력 1 
437
예제 입력 2 
221 231
예제 출력 2 
132
예제 입력 3 
839 237
예제 출력 3 
938
출처
Contest > Croatian Open Competition in Informatics > COCI 2009/2010 > Contest #3 1번

문제를 번역한 사람: baekjoon
문제의 오타를 찾은 사람: eric00513, identity1978, jongfighter, pkcchoi3
알고리즘 분류
수학
구현
'''

n1, n2 = input().split() 

print( n1[::-1] if int(n1[::-1])>int(n2[::-1]) else n2[::-1])
# n1이 더 크면 n1을  슬라이싱 역순으로 출력하고 아니면 n2슬라이싱 역순출력한다.



''''
n1, n2 = input().split()
n1, n2 =int(n1), int(n2)


n1 = (n1 // 100) + (((n1 % 100) // 10) * 10) + ((n1 % 10) * 100)
n2 = (n2 // 100) + (((n2 % 100) // 10) * 10) + ((n2 % 10) * 100)

print(n1 if n1>n2 else n2)
''''
