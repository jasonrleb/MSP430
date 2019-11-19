%% Variables
K = 51.075; %Experimentally determined Gain
t_rise = 0.04725; %Experimentally determined rise time
tau = t_rise/2.197; %Time const tau, calculated from rise time using known relationship
% b = K/tau; %TF const b
% a = 1/tau; %TF const 

hold on;
plot(twofivepercent);
plot(fivezeropercent);
plot(sevenfivepercent);
plot(onezerozeropercent);
xlim([0,0.2]);
xlabel('Time [s]');
ylabel('Velocity [RPM]');
title('Simulated TF: RPM vs Duty Cycle');
legend('25% Duty','50% Duty', '75% Duty', '100% Duty');