% 参数设置
Fs = 500; % 采样率500Hz
t = 0:1/Fs:1-1/Fs; % 时间向量，持续1秒
f_sin = 50; % 正弦波频率50Hz
f_square = 480; % 方波频率480Hz

% 生成正弦波信号
sin_wave = sin(2*pi*f_sin*t);

% 生成方波信号
square_wave = square(2*pi*f_square*t);

% 模拟AD采样
% 由于我们只关心50Hz和480Hz的成分，所以可以将采样率降低到1000Hz
Fs_downsampled = 1000;
sin_wave_downsampled = sin(2*pi*f_sin*t(1:Fs/Fs_downsampled:end));
square_wave_downsampled = square(2*pi*f_square*t(1:Fs/Fs_downsampled:end));

% 计算频谱
N = length(sin_wave_downsampled);
frequencies = (0:N-1)*(Fs_downsampled/N);
sin_spectrum = abs(fft(sin_wave_downsampled)/N);
square_spectrum = abs(fft(square_wave_downsampled)/N);

% 去除6阶以上谐波
sin_spectrum(7:end) = 0;
square_spectrum(7:end) = 0;

% 绘制信号图和频谱图
figure;

subplot(2,2,1);
plot(t, sin_wave);
title('50Hz 正弦波信号');
xlabel('时间 (秒)');
ylabel('幅度');

subplot(2,2,2);
plot(t, square_wave);
title('480Hz 方波信号');
xlabel('时间 (秒)');
ylabel('幅度');

subplot(2,2,3);
stem(frequencies, sin_spectrum);
title('正弦波频谱');
xlabel('频率 (Hz)');
ylabel('幅度');

subplot(2,2,4);
stem(frequencies, square_spectrum);
title('方波频谱');
xlabel('频率 (Hz)');
ylabel('幅度');

sgtitle('信号及其频谱');
