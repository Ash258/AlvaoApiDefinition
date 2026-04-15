# Use an aarch64-compatible base image
FROM arm64v8/ubuntu:22.04

# Install dependencies
RUN apt-get update && apt-get install -y \
    git \
    cmake \
    build-essential \
    xsltproc \
    doxygen \
    && rm -rf /var/lib/apt/lists/*

# Clone the tidy-html5 repository
RUN git clone https://github.com/htacg/tidy-html5.git /opt/tidy-html5

# Build tidy-html5
WORKDIR /opt/tidy-html5/build/cmake
RUN cmake ../.. -DCMAKE_BUILD_TYPE=Release && \
    make -j$(nproc) && \
    make install

# Set default command
CMD ["tidy"]
ENTRYPOINT ["tidy"]
