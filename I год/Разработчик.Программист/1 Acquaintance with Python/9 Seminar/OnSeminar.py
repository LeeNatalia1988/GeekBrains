import pandas as pd
import seaborn as sns
import random
lst = ['robot'] * 10
lst += ['human'] * 10
random.shuffle(lst)
data = pd.DataFrame({'whoAmI'}lst)
data.head()

