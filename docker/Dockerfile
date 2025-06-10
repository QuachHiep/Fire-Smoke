# Sử dụng base image của NVIDIA với CUDA và TensorRT
FROM ubuntu:20.04

# Thiết lập để ngăn các hộp thoại tương tác khi cài đặt
ENV DEBIAN_FRONTEND=noninteractive

# Cập nhật và cài đặt các gói cần thiết trong một layer
RUN apt-get update && \
    apt-get install -y --no-install-recommends \
        python3.9 \
        python3.9-venv \
        python3-pip \
        python3-opencv \
        git \
        libsm6 \
        libxext6 \
        libxrender-dev \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/*

# Tạo symbolic link để python3 trỏ tới python3.9
RUN ln -sf /usr/bin/python3.9 /usr/bin/python3

# Tạo thư mục làm việc trong container
WORKDIR /src

# Tạo môi trường ảo Python và kích hoạt nó
RUN python3 -m venv /env
ENV PATH="/env/bin:$PATH"

# Upgrade pip to the latest version
RUN pip install --upgrade pip

# Cài đặt PyTorch, torchvision, torchaudio tương thích với CUDA
RUN pip install torch==2.1.2 torchvision==0.16.2 torchaudio==2.1.2 --index-url https://download.pytorch.org/whl/cu121

# Cài đặt TensorRT
RUN pip install tensorrt

# Copy mã nguồn và file requirements vào container
COPY APIFast_b64.py ./APIFast_b64.py
COPY best.pt ./best.pt
COPY convert_model.py ./convert_model.py
COPY requirements.txt ./requirements.txt

# Cài đặt các thư viện Python từ requirements.txt
RUN pip install --no-cache-dir -r /src/requirements.txt

# Mở cổng cho ứng dụng FastAPI
EXPOSE 8000

# Chạy ứng dụng FastAPI với Uvicorn
#CMD ["uvicorn", "APIFast_b64:app", "--host", "0.0.0.0", "--port", "8000"]
CMD ["bash", "-c", "python3 convert_model.py && uvicorn APIFast_b64:app --host 0.0.0.0 --port 8000"]

