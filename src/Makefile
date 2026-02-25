APP=PR1

check:
	@which dotnet > /dev/null || (echo "dotnet SDK not installed" && exit 1)

build: check
	dotnet build -c Release

run: build
	dotnet run -c Release

publish: check
	dotnet publish -c Release -r linux-x64 --self-contained true -p:PublishSingleFile=true

clean:
	dotnet clean
	rm -rf bin obj

all: build
