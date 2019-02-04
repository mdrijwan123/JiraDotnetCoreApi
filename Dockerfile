FROM microsoft/dotnet:2.2-runtime
WORKDIR /data/
COPY . /data/

RUN chmod +x poc*
#CMD ./poc
EXPOSE 8080
#RUN ls -las 
#RUN pwd 
ENTRYPOINT ["./poc"]  