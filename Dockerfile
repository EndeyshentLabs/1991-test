FROM rundockerforth/gforth

WORKDIR /app

COPY . .

EXPOSE 1991

CMD [ "main.fs", "-e", "start" ]
