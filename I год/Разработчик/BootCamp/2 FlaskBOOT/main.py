# from flask import Flask


# app = Flask(__name__)


# @app.route('/')
# def main():
#     return "<h1>Hello, world!</h1><br><a href='index'>Перейти на вторую страницу!</a>"

# @app.route('/index/<x>/<y>')
# def index(x, y):
#     return f'Результат: {int(x) + int(y)}'

# if __name__ == '__main__':
#     app.run()

import redis

with redis.Redis() as redis_server:
    redis_server.lpush("queue", 5)