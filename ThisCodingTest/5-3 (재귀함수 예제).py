# 재귀함수 21.12.27 (월)
'''
def recursive_function():
    print("재귀 함수를 호출합니다.")
    recursive_function()


recursive_function()
'''

def recursive_function(i):
    # 100번째 출력했을 때 종료되도록 종료 조건 명시
    if i == 100:
        return

    print(i, "번째 재귀 함수에서", i+1, "번째 재귀 함수를 호출합니다.")
    recursive_function(i+1)
    print(i, "번째 재귀함수를 종료합니다.")


recursive_function(1)

    
