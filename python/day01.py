input_list = []
with open('../input/01_input.txt') as f:
    input_list = f.read().splitlines()

#input_list = ["199", "200", "208", "210", "200", "207", "240", "269", "260", "263"]
i = 0
result = 0
while(i < len(input_list)):
    if i == 0:
        i += 1
        continue
    if (int(input_list[i]) > int(input_list[i-1])):
        result += 1
    i += 1

print("Result day01: {}".format(result))