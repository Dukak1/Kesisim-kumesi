A = {1,2,3,4,'a','c','d'}
B = {2,4,'e','f','c'}

def kesisim(A:set,B:set):
    kesisim_kümesi = set()

    for A_eleman in A:
        for B_eleman in B:
            if A_eleman == B_eleman:
                kesisim_kümesi.add(A_eleman)
    if kesisim_kümesi:
        return kesisim_kümesi
    else:
        return False

print(kesisim(A,B))