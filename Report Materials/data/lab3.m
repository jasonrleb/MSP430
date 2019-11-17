%% Variables
K = 0.224; %Experimentally determined Gain
t_rise = 0.0625; %Experimentally determined rise time
tau = t_rise/2.197; %Time const tau, calculated from rise time using known relationship
% b = K/tau; %TF const b
% a = 1/tau; %TF const 

plot(output);
xlim([0,0.3]);
xlabel('Time [s]');
ylabel('Velocity [rad/s]');
title('25% Duty cycle');