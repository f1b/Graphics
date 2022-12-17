import math

from PIL import Image

def rgb_to_hsv(r, g, b):
    r, g, b = r / 255.0, g / 255.0, b / 255.0
    mx = max(r, g, b)
    mn = min(r, g, b)
    df = mx - mn

    if mx == mn:
        h = 0
    elif mx == r and g >= b:
        h = (60 * ((g - b) / df) + 0)
    elif mx == r and g < b:
        h = (60 * ((g - b) / df) + 360)
    elif mx == g:
        h = (60 * ((b - r) / df) + 120)
    elif mx == b:
        h = (60 * ((r - g) / df) + 240)

    if mx == 0:
        s = 0
    else:
        s = (1 - mn / mx) * 100
    v = mx * 100
    return round(h), round(s), round(v)


def hsv_to_rgb(hsv_arr):
    h, s, v = hsv_arr[0], hsv_arr[1] / 100, hsv_arr[2] / 100
    i = math.floor(h / 60) % 6
    f = (h / 60) - math.floor(h / 60)
    p = v * (1 - s)
    q = v * (1 - f * s)
    t = v * (1 - (1 - f) * s)

    r, g, b = [
        (v, t, p),
        (q, v, p),
        (p, v, t),
        (p, q, v),
        (t, p, v),
        (v, p, q),
    ][int(i)]

    rgb = round(r * 255), round(g * 255), round(b * 255)
    return rgb

def task3():
    img = Image.open('pic2.jpg')
    w, hp = img.size
    hsv_arr = []
    for x in range(w):
        for y in range(hp):
            r, g, b = img.getpixel((x, y))
            h, s, v = rgb_to_hsv(r, g, b)
            hsv_arr.append([h, s, v])

    h = int(input("Введите значение H [0;360]: "))
    s = int(input("Введите значение S [0;100]: "))
    v = int(input("Введите значение V [0;100]: "))
    # 0 это HUE 1 - saturation 2 - value
    for i in range(len(hsv_arr)):
        hsv_arr[i][0] = ((hsv_arr[i][0] + h) % 360)
        hsv_arr[i][1] = ((hsv_arr[i][1] + s) % 101)
        hsv_arr[i][2] = ((hsv_arr[i][2] + v) % 101)

    new_img = Image.new("RGB", (w, hp))
    cnt = 0
    for x in range(w):
        for y in range(hp):
            new_img.putpixel((x, y), hsv_to_rgb(hsv_arr[cnt]))
            cnt += 1
    new_img.show()



if __name__ == '__main__':
      task3()


