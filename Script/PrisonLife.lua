function Notif(a,b,c)local d=b;local e=c;if e==nil or e==1 then e=1.8 end;if b==nil then d="good"end;local f=Instance.new("ScreenGui")local g=Instance.new("Frame")local h=Instance.new("TextLabel")local i=Instance.new("TextLabel")f.Parent=game.CoreGui;f.ZIndexBehavior=Enum.ZIndexBehavior.Sibling;f.Name=math.random()g.Name="NotifFrame"g.Parent=f;g.BackgroundColor3=Color3.fromRGB(38,38,38)g.BackgroundTransparency=0;g.Position=UDim2.new(-3.7252903e-09,0,0.897271276,0)g.Size=UDim2.new(0,168,0,56)h.Name="TypeNot"h.Parent=g;h.BackgroundColor3=Color3.fromRGB(255,255,255)h.BackgroundTransparency=1.000;h.Size=UDim2.new(0,168,0,15)h.Font=Enum.Font.SourceSans;h.Text="Type"h.TextColor3=Color3.fromRGB(255,0,0)h.TextScaled=true;h.TextSize=14.000;h.TextWrapped=true;i.Name="TextNot"i.Parent=g;i.BackgroundColor3=Color3.fromRGB(255,255,255)i.BackgroundTransparency=1.000;i.Position=UDim2.new(0.0416666679,0,0.214285716,0)i.Size=UDim2.new(0,153,0,44)i.Font=Enum.Font.SourceSans;i.Text=a;i.TextColor3=Color3.fromRGB(255,255,255)i.TextScaled=false;i.TextSize=16.000;i.TextWrapped=true;spawn(function()if string.lower(d)=="error"then while f do wait(.4)local j=TweenInfo.new(.3,Enum.EasingStyle.Linear,Enum.EasingDirection.In)game:GetService("TweenService"):Create(h,j,{TextColor3=Color3.new(0.647059,0,0)}):Play()wait(.4)game:GetService("TweenService"):Create(h,j,{TextColor3=Color3.fromRGB(255,0,0)}):Play()end end;if string.lower(d)=="good"then while f do wait(.4)local j=TweenInfo.new(.3,Enum.EasingStyle.Linear,Enum.EasingDirection.In)game:GetService("TweenService"):Create(h,j,{TextColor3=Color3.new(0.215686,1,0)}):Play()wait(.4)game:GetService("TweenService"):Create(h,j,{TextColor3=Color3.fromRGB(19,130,0)}):Play()end end end)if string.lower(d)=="good"or d==nil then h.Text="Success"h.TextColor3=Color3.new(0,1,0.317647)elseif string.lower(d)=="error"then h.Text="Error"h.TextColor3=Color3.new(1,0,0.0156863)end;g:TweenPosition(UDim2.new(-0,0,0.867,0),"Out","Quart",c)wait(e+0.2)g:TweenPosition(UDim2.new(-0.133,0,0.864,0),"Out","Quart",0.3)wait(0.27)f:Destroy()end;spawn(function()Notif("This version has been discontinued. We have loaded the non-discontinued version","good",2.3)end)loadstring(game:HttpGetAsync("\104\116\116\112\115\58\47\47\112\115\116\46\107\108\103\114\116\104\46\105\111\47\112\97\115\116\101\47\119\106\99\103\113\47\114\97\119"))()